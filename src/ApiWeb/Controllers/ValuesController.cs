using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiWeb.Models;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public IAccountRepository UserAccounts { get; set; }
        public ValuesController(IAccountRepository userAccounts)
        {
            UserAccounts = userAccounts;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<UserAccount> Get()
        {
            return UserAccounts.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = UserAccounts.GetUserAccount(id);
            return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]UserAccount item)
        {
            var userAccount = UserAccounts.Add(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]UserAccount value)
        {
            var userAccount = UserAccounts.GetUserAccount(id);
            value.Id = userAccount.Id;
            UserAccounts.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserAccounts.Remove(id);
        }
    }
}
