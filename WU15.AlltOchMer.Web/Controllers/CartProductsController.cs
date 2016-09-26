using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using WU15.AlltOchMer.Web.Entity;

namespace WU15.AlltOchMer.Web.Controllers
{
    public class CartProductsController : ApiController
    {
        private DefaultDataContext db = new DefaultDataContext();

        // GET: api/CartProducts
        [HttpGet]
        [Route("api/CartProduct/SE/")]
        public IEnumerable<CartProductSweden> GetCartProduct()
        {
            return db.CartProductSweden.ToList();
        }

        // GET: api/CartProducts/5
        [HttpGet]
        [Route("api/CartProduct/SE/{id}")]
        [ResponseType(typeof(CartProduct))]
        public IHttpActionResult GetCartProduct(int id)
        {
            CartProduct cartProduct = db.CartProduct.Find(id);
            if (cartProduct== null)
            {
                return NotFound();
            }

            return Ok(cartProduct);
        }


        // PUT: api/CartProducts/5
        [HttpGet]
        [Route("api/CartProduct/SE/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCartProduct(int id, CartProduct cartProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cartProduct.Id)
            {
                return BadRequest();
            }

            db.Entry(cartProduct).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CartProducts

        [HttpGet]
        [Route("api/CartProduct/SE/{productid}/{quantity}/{price}")]
        [ResponseType(typeof(CartProduct))]
        public IHttpActionResult PostCartProduct(int productId, int quantity, int price)
        {
            var cartProduct = new CartProduct();
            Cart cart = new Cart();

            //make a test if cart empty add a cart
            var cartInit = db.Cart.Count();
            if (cartInit == 0)
            {
                cart.Guid = new Guid("3d13c771-a713-463e-8fa2-27dbb62ad358");
                cart.CreationDate = DateTime.Now;
                db.Cart.Add(cart);
                db.SaveChanges();
            }
            //Add item only if Product does'nt exist
            var CartProd = db.CartProductSweden.Where(p => p.ProductId == productId);

            if (!CartProd.Any())
            {
                cartProduct.CartGuid = new Guid("3d13c771-a713-463e-8fa2-27dbb62ad358");
                cartProduct.ProductId = productId;
                cartProduct.Quantity = quantity;
                cartProduct.Pris = price;
                db.CartProduct.Add(cartProduct);                
                db.SaveChanges();
            }
            
                    
            return CreatedAtRoute("CartProductSweden", new { id = cartProduct.Id }, cartProduct);  
        }

          // DELETE: api/CartProducts/5
          [HttpDelete]
          [Route("api/CartProduct/SE/{id}")]
          [ResponseType(typeof(CartProduct))]
            public IHttpActionResult DeleteCartProduct(int id)
          {

              CartProduct cartProduct= db.CartProduct.SingleOrDefault(x => x.Id == id);
                if (cartProduct== null)
                {
                    return NotFound();
                }

                db.CartProduct.Remove(cartProduct);
              try
              {
                  db.SaveChanges();
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
                  
              }
            return Ok(cartProduct);
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                base.Dispose(disposing);
            }

            private bool CartProductExists(int id)
            {
                return db.CartProduct.Count(e => e.Id == id) > 0;
            }
                }
            }