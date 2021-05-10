using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogum_core.Helpers;
using blogum_db.dtos;
using blogum_db.repositories;
using Microsoft.AspNetCore.Mvc;

namespace blogum_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(
            ICategoryRepository categoryRepository
            )
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<CategoryDto>> GetCategories()
        {
            var categories = (await _categoryRepository.GetAllActive()).ToList();

            var result = AppMapper.Map<List<CategoryDto>>(categories);

            return result;
        }
    }
}
