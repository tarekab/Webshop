using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Microsoft.ApplicationInsights.WindowsServer;
using WU15.AlltOchMer.Web.Entity;

namespace WU15.AlltOchMer.Web.Controllers
{
    public class CategoryController : ApiController
    {
        private DefaultDataContext db = new DefaultDataContext();
        [Route("api/Category/SE/")]
        [HttpGet]
        public IEnumerable<SwedishMainCategory> GetSwedishMainCategories()
        {
            var query = from b in db.SwedishMainCategory
                        
                        select b;
            return query;

        }

        [HttpGet]
        [Route("api/Category/SE/{id}")]
        public IHttpActionResult GetCategoryById(int id)
        {
            var catego = db.SwedishMainCategory.FirstOrDefault(ca => ca.Id == id);
            if (catego == null)
            {
                return NotFound();
            }
            return Json(catego);
        }
        
        [HttpGet]
        [Route("api/Category/SE/Prod/{id}")]
        public IEnumerable<ProductSe> GetSEProductByCategory(int id)
        {
            
            var query = from b in db.ProductSe
                        where b.CategoryId == id
                        select b;
            return query;
        }
        [Route("api/Category/NO/")]
        [HttpGet]
        public IEnumerable<NorwegianMainCategory> GetNorwegianMainCategories()
        {
            var query = from b in db.NorwegianMainCategory
                        orderby b.Name
                        select b;
            return query;
        }
        [Route("api/Category/NO/Prod/{id}")]
        public IEnumerable<ProductNo> GetNOProductByCategory(int id)
        {
            var query = from b in db.ProductNo
                where b.CategoryId == id
                select b;
            return query;
        }

        [Route("api/Category/DK/")]
        [HttpGet]
        public IEnumerable<DanishMainCategory> GetDanishMainCategories()
        {
            var query = from b in db.DanishMainCategory
                        orderby b.Name
                        select b;
            return query;
        }
        [Route("api/Category/DK/Prod/{id}")]
        public IEnumerable<ProductDk> GetDKProductByCategory(int id)
        {
            var query = from b in db.ProductDk
                        where b.CategoryId == id
                        select b;
            return query;
        }

    }
}
