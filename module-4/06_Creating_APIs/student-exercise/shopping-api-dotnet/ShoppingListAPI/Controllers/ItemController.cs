using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingListAPI.Models;
using ShoppingListAPI.Services;

namespace ShoppingListAPI.Controllers
{
    [Route("api/groceries")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private DataAccessObject dao;

        public ItemController(DataAccessObject dao)
        {
            this.dao = dao;
        }

        /// <summary>
        /// Returns all items.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Item>> GetAll()
        {
            List<Item> items = dao.GetAll();
            return Ok(items);
        }

        [HttpGet("{id}", Name = "GetItemById")]
        public ActionResult<Item> Get(int id)
        {
            Item item = dao.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }


        [HttpPost]
        public ActionResult<Item> Add([FromBody]Item item)
        {
            // Save in the dao
            dao.Add(item);

            // Return 201 (with a location header: https://localhost:44359/api/reviews/{id})
            // First parameter - Name of the route to generate for API
            // Second parameter - The variables for the route. It expects an object. 
            // Third parameter - The response body
            return CreatedAtRoute("GetItemById", new { id = item.Id }, item);
        }


        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody]Item item)
        {
            Item existingItem = dao.Get(id);
            if (existingItem == null)
            {
                return NotFound();
            }

            //Copy over the fields we want to update
            existingItem.name = item.name;
            existingItem.completed = item.completed;

            //Save existing review back
            dao.Update(item);

            return NoContent();

        }


        /// <summary>
        /// Deletes an item.
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Item item = dao.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            dao.Delete(id);
            return NoContent();
        }

        

    }
}