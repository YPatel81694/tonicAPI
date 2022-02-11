#nullable disable

using Microsoft.AspNetCore.Mvc;
using tonicAPI.Models.Repository;
using tonicAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/ToDoItems")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly DataRepository<ToDoItem> _dataRepository;
        public TodoItemsController(DataRepository<ToDoItem> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/TodoItems
        [HttpGet]
        public IActionResult Get()
        {
            var items = _dataRepository.GetAll();
            return Ok(items);
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public IActionResult GetItem(long id)
        {
            var item = _dataRepository.Get(id);
            if (item == null)
            {
                return NotFound("The item does not exist.");
            }
            return Ok(item);
        }

        // PUT: api/TodoItems/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ToDoItem item)
        {
            if (item == null)
            {
                return BadRequest("Item is null.");
            }
            var itemToUpdate = _dataRepository.Get(id);
            if (itemToUpdate == null)
            {
                return NotFound("The item does not exist.");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _dataRepository.Update(id, item);
            return NoContent();
        }

        // POST: api/TodoItems
        [HttpPost]
        public IActionResult Post([FromBody] ToDoItem item)
        {
            if (item is null)
            {
                return BadRequest("Item is null.");
            }
            _dataRepository.Add(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }


        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var item = _dataRepository.Get(id);
            if (item == null)
            {
                return NotFound("The item does not exist.");
            }
            _dataRepository.Delete(id);
            return NoContent();
        }

    }
}
