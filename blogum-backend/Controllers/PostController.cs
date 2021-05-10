using System.Collections.Generic;
using System.Threading.Tasks;
using blogum_db.dtos;
using blogum_db.repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using blogum_core.Helpers;
using blogum_db.models;

namespace blogum_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController
    {
        private readonly IPostRepository _postRepository;

        public PostController(
            IPostRepository postRepository
            )
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<PostDto>> GetPosts()
        {
            var posts = (await _postRepository.GetAllActive()).ToList();

            var result = AppMapper.Map<List<PostDto>>(posts);

            return result;
        }

        [HttpPost]
        [Route("")]
        public async Task<PostDto> CreatePost([FromBody]PostDto postDto)
        {
            var entity = AppMapper.Map<Post>(postDto);

            var result = await _postRepository.Insert(entity);

            postDto.Id = result;

            return postDto;
        }
    }
}
