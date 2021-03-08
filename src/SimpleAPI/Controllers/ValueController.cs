
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace SimpleAPI.Controllers
{     [ApiController]
    [Route("[controller]")]
    public class ValueController: ControllerBase
    { //get:api/values
            [HttpGet]
        public IEnumerable<string> Get()
         {
            return new string[]{"value1","value2","Romeeta"};
         }
        //get:api/values
            [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
         {
            return "Romeeta Sharma";
         }
         //post :api /values
         public void Post([FromBody]string value)
         {
         }
         //put :api /values/5
         public void put(int id,[FromBody]string value)
         {
         }         public void Delete(int id)
         {

         } 
    }
}