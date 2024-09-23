using AutoMapper;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.ToDoListDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class ToDoListMapping:Profile
	{
		public ToDoListMapping()
		{
			CreateMap<ToDoList, ResultToDoListDto>().ReverseMap();
			CreateMap<ToDoList, CreateToDoListDto>().ReverseMap();
			CreateMap<ToDoList, GetToDoListDto>().ReverseMap();
			CreateMap<ToDoList, UpdateToDoListDto>().ReverseMap();
		}

	}
}
