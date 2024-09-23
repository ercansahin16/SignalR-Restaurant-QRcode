using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.CategoryDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class CategoryController : ControllerBase
   {
      private readonly ICategoryService _categoryService;
      private readonly IMapper _mapper;

      public CategoryController(ICategoryService categoryService, IMapper mapper)
      {
         _categoryService = categoryService;
         _mapper = mapper;
      }
      [HttpGet]
      public IActionResult CategoryList()
      {
         var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
         return Ok(values);
      }


      [HttpGet("CategoryCount")]
      public IActionResult CategoryCount() 
      { 
         return Ok(_categoryService.TCategoryCount());
      }

		[HttpGet("ActiveCategoryCount")]
		public IActionResult ActiveCategoryCount()
		{
			return Ok(_categoryService.TActiveCategoryCount());
		}

		[HttpGet("PassiveCategoryCount")]
		public IActionResult PassiveCategoryCount()
		{
			return Ok(_categoryService.TPassiveCategoryCount());
		}

		[HttpPost]
      public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
      {
         _categoryService.TAdd(new Category()
         {
            CategoryName = createCategoryDto.CategoryName,
            CategoryStatus = true
         });
         return Ok("Kategori eklendi");
      }

      [HttpDelete("{id}")]
      public IActionResult DeleteCategory(int id)
      {
         var values = _categoryService.TGetByID(id);
         _categoryService.TDelete(values);
         return Ok("Kategori Silindi");
      }

      [HttpGet("{id}")]
      public IActionResult GetCategory(int id)
      {
         var values = _categoryService.TGetByID(id);
         return Ok(values);
      }

      [HttpPut]
      public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
      {
         _categoryService.TUpdate(new Category()

         {
            CategoryName = updateCategoryDto.CategoryName,
            CategoryID = updateCategoryDto.CategoryID,
            CategoryStatus = updateCategoryDto.CategoryStatus
         });
         return Ok("Kategori Güncellendi");

      }





   }
}
