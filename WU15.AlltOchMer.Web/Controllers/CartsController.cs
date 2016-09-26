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
using WU15.AlltOchMer.Web.Entity;

namespace WU15.AlltOchMer.Web.Controllers
{
    public class CartsController : ApiController
    {
        private DefaultDataContext db = new DefaultDataContext();

        // GET: api/Carts
        [HttpGet]
        [Route("api/Cart/SE/")]
        public IQueryable<Cart> GetCart()
        {
            return db.Cart;
        }

        [HttpGet]
        [Route("api/Cart/SE/{id}")]
        // GET: api/Carts/5
        [ResponseType(typeof(Cart))]
        public IHttpActionResult GetCart(int id)
        {
            Cart cart = db.Cart.Find(id);
            if (cart == null)
            {
                return NotFound();
            }

            return Ok(cart);
        }

        // PUT: api/Carts/5
       
        [Route("api/Cart/SE/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCart(int id, Cart cart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cart.Id)
            {
                return BadRequest();
            }

            db.Entry(cart).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartExists(id))
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

        // POST: api/Carts
       
        [Route("api/Cart/SE/")]
        [ResponseType(typeof(Cart))]
        public IHttpActionResult PostCart(Cart cart)
        {
            

            cart.Guid = Guid.NewGuid();
            cart.CreationDate=DateTime.Now;
            db.Cart.Add(cart);
            db.SaveChanges();

            return CreatedAtRoute("CartSweden", new { id = cart.Id }, cart);
        }

        // DELETE: api/Carts/5
      
        [Route("api/Cart/SE/{id}")]
        [ResponseType(typeof(Cart))]
        public IHttpActionResult DeleteCart(int id)
        {
            Cart cart = db.Cart.Find(id);
            if (cart == null)
            {
                return NotFound();
            }

            db.Cart.Remove(cart);
            db.SaveChanges();

            return Ok(cart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CartExists(int id)
        {
            return db.Cart.Count(e => e.Id == id) > 0;
        }
    }
}