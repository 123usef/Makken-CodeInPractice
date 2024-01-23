using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Context;
using TodoAPI.Model;

namespace TodoAPI.Controllers
{
	[Route("api/[controller]")]
	//[Route("api/Todo")]
	[ApiController]
	public class TodoController : ControllerBase
	{
		private readonly ApplicationDbContext _dbContext;

		public TodoController(ApplicationDbContext DbContext)
		{
			_dbContext = DbContext;
		}

		[HttpGet]
		[ProducesResponseType(statusCode: 200)]
		[ProducesResponseType(statusCode: 404)]
		//[ProducesResponseType(statusCode:200)]
		public ActionResult Getall()
		{
			var todos = _dbContext.todos.ToList();
			if (todos.Count > 0)
			{
				return Ok(todos);

			}

			return NotFound();
		}

		///public IEnumerable<Todo> Getall()
		///{
		///	var todos = new List<Todo>()
		///	{
		///		new Todo{Id=1, Name="Api Study" ,Description="I have to studey Api's Well" },
		///		new Todo{Id=2, Name="Mvc Study" ,Description="I have to studey Mvc Well" },
		///		new Todo{Id=3, Name="Dal Implemntation" ,Description="I have to start Implementation For Dal" },
		///		new Todo{Id=4, Name="Bll implmentation" ,Description="I have to start Implemntation For Busniess Logic Layer" },
		///		new Todo{Id=5, Name="PL Implementation" ,Description="I have to start implementation for Presentation Layer" },
		///	};
		///	return todos;
		///}

		[HttpGet("id:int")]
		[ProducesResponseType(statusCode: 200)]
		[ProducesResponseType(statusCode: 404)]
		//[ProducesResponseType(statusCode:200)]
		public ActionResult Get(int id)
		{
			if (id == 0)
			{
				return BadRequest();
			}
			var todo = _dbContext.todos.Find(id);
			if (todo is null)
			{
				return NotFound("Todo is not Found");

			}

			return Ok(todo);

		}

		[HttpPost]
		public ActionResult Create(Todo todo) {
			if (ModelState.IsValid)
			{
				_dbContext.todos.Add(todo);
				_dbContext.SaveChanges();
				return Ok(todo);
			}	
			return BadRequest();
		
		
		}
	}
}