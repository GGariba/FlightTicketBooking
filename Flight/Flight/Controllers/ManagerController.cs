﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassEX3.Models;

namespace ClassEX3.Controllers
{
    public class ManagerController : ApiController
    {
        // GET api/<controller>
      /*  public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/<controller>/5
        public IEnumerable<Discount> Get()
        {
            Discount dis = new Discount();
            return dis.getAllDiscounts();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public Manager Post([FromBody]Manager Man)
        {
            if (Man.checkManager())
            {
                return Man;

            }
            return null;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // POST api/<controller>
        public List<Discount> Post([FromBody]Discount discount)
        {
            Discount dis = new Discount();
            dis.insertDiscount(discount);
            return dis.getAllDiscounts();
        }

        [HttpPut]
        [Route("api/Manager")]
        public List<Discount> Put (Discount discount)
        {
            Discount dis = new Discount();
            dis.UpdateDiscounts(discount);
            return  dis.getAllDiscounts();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}