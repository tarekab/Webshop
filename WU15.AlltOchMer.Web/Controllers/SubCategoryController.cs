using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WU15.AlltOchMer.Web.Entity;

namespace WU15.AlltOchMer.Web.Controllers
{
    public class SubCategoryController : ApiController
    {
        private DefaultDataContext db = new DefaultDataContext();

        [Route("api/SubCategory/SE/")]
        [HttpGet]
        public IEnumerable<SwedishSubcategory> GetSwedishSubCategories()
        {
            var query = from b in db.SwedishSubcategory
                        orderby b.Name //where b.ParentsId==id
                        select b;
            return query;
        }        
       [Route("api/SubCategory/SE/{id}")]
        [HttpGet]
        public IEnumerable<Subcategories> GetSwedishSubCategories(int id)
        {
          
            var query = from b in db.Subcategories
                        where b.Category_Id==id
                        select b;
            return query;
        }
    }
}
