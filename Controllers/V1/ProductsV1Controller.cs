using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApplication2.Controllers.V1
{
    [RoutePrefix("api/v1/products")]
    public class ProductsV1Controller : ApiController
    {
        [Route("{productId}", Name = "ProductV1")]
        [ResponseType(typeof(ProductModel))]
        public IHttpActionResult Get([FromUri] ProductParameter parameter)
        {
            return this.Ok(new ProductModel());
        }
    }

    public class ProductModel { }

    public class ProductParameter
    {
        // If this is the only property in this object,
        // ApiExplorer capitalizes the {productId} token in the route template.
        public Guid ProductId { get; set; }

        // If this second property is added to this object,
        // ApiExplorer leaves the {productId} token in camel-case in the route template.
        // For some reason, it has to be a List<T>. A value property will not work.
        //public List<string> Foobar { get; set; }
    }
}
