using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.ToDoListDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoListsController : ControllerBase
	{
		private readonly IToDoListService _toDoListService;
		private readonly IMapper _mapper;

		public ToDoListsController(IToDoListService toDoListService, IMapper mapper)
		{
			_toDoListService = toDoListService;
			_mapper = mapper;
		}



		[HttpGet]
		public IActionResult ToDoListList()
		{
			var values = _toDoListService.TGetListAll();
			return Ok(values);
		}

      [HttpGet("ToDoMinute")]
      public IActionResult ToDoMinute()
      {
         var values = _toDoListService.TToDoMinute();
         return Ok(values);
      }



      [HttpPost]
		public IActionResult CreateToDoList(CreateToDoListDto createToDoListDto)
		{
			ToDoList toDoList = new ToDoList()
			{
				Date = createToDoListDto.Date,
				Title = createToDoListDto.Title,
				Description = createToDoListDto.Description
			};
			_toDoListService.TAdd(toDoList);
			return Ok("To Do Eklendi.");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteToDoList(int id)
		{
			var values = _toDoListService.TGetByID(id);
			_toDoListService.TDelete(values);
			return Ok("To Do silindi");
		}

		[HttpPut]
		public IActionResult UpdateToDoList(UpdateToDoListDto updateToDoList)
		{

			ToDoList toDoList = new ToDoList()
			{
				Date = updateToDoList.Date,
				Title = updateToDoList.Title,
				Description = updateToDoList.Description,
				ID = updateToDoList.ID
			};
			_toDoListService.TUpdate(toDoList);
			return Ok("To Do güncellendi");
		}

		[HttpGet("{id}")]
		public IActionResult GetToDoList(int id)
		{
			var values = _toDoListService.TGetByID(id);
			return Ok(values);
		}










	}
}
