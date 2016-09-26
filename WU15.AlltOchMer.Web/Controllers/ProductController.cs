using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.DynamicData;
using System.Web.Http;
using WebGrease.Css.Ast.Selectors;
using WU15.AlltOchMer.Web.Entity;

namespace WU15.AlltOchMer.Web.Controllers
{
    public class ProductController : ApiController
    {
        private DefaultDataContext db =new DefaultDataContext();
        [Route("api/Product/SE/")]
        [HttpGet]
        public IEnumerable<ProductSe>GetProdSweden()
        {
           return db.ProductSe.ToList();           
        }

        [Route("api/Product/SE/Random")]
        [HttpGet]
        public IEnumerable<ProductRandomSe> GetProdRandomSweden()
        {
            return db.ProductRandomSe.ToList();

        }


        [HttpGet]
        [Route("api/Product/SE/{id}")]
        public IHttpActionResult GetProdSwedenById(int id)
        {
            var query = (from b in db.MainCategorySweden
                        where b.id == id 
                        
                        select b).FirstOrDefault();
            return Json(query);
        }

        [Route("api/Product/NO/")]
        [HttpGet]
        public IEnumerable<ProductNo> GetProdNorway()
        {
            return db.ProductNo.ToList();
        }

        [HttpGet]
        [Route("api/Product/NO/{id}")]
        public IHttpActionResult GetPrododNorwayById(int id)
        {
            var prod = db.MainCategoryNorway.FirstOrDefault(ca => ca.id== id);
            if (prod == null)
            {
                return NotFound();
            }
            return Json(prod);
        }

        [Route("api/Product/DK/")]
        [HttpGet]
        public IEnumerable<ProductDk> GetProdDanmark()
        {
            return db.ProductDk.ToList();
        }

        [HttpGet]
        [Route("api/Product/DK/{id}")]
        public IHttpActionResult GetPrododDanmarkById(int id)
        {
            var prod = db.MainCategoryDanmark.FirstOrDefault(ca => ca.id == id);
            if (prod == null)
            {
                return NotFound();
            }
            return Json(prod);
        }




    }
}
