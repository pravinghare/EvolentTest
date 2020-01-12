using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessObject;
using MachineTestEvolent.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace MachineTestEvolent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactManager _contactManager;

        public ContactController(IContactManager contactManager)
        {
           _contactManager = contactManager;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var Contacts = await _contactManager.GetContactAsync();
            return Ok(Contacts);
        }

       

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ContactEntity contact)
        {
            ContactEntity AddedContact = await _contactManager.AddContactAsync(contact);
            return Ok(AddedContact);
        }


        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Edit([FromBody] ContactEntity contact)
        {
            ContactEntity EditContact = await _contactManager.EditContactAsync(contact);
            return Ok(EditContact);
        }

       

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool DeleteContact= await _contactManager.DeleteContactAsync(id);
            return Ok(DeleteContact);
        }
    }
}
