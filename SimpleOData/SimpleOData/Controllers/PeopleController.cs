using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;
using SimpleOData.DataSource;

namespace SimpleOData.Controllers
{
    [EnableQuery]
    public class PeopleController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(DemoDataSources.Instance.People.AsQueryable());
        }
    }
}