using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogum_core.Helpers;
using blogum_db.dtos;
using blogum_db.models;
using blogum_db.repositories;
using Microsoft.AspNetCore.Mvc;

namespace blogum_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController
    {
        private readonly ICommentRepository _commentRepository;

        public CommentController(
            ICommentRepository commentRepository
            )
        {
            _commentRepository = commentRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<List<CommentDto>> GetCommentsByPost(long postId)
        {
            var comments = (await _commentRepository.GetAll(o => o.IsActive && o.PostId == postId)).ToList();

            var result = AppMapper.Map<List<CommentDto>>(comments);

            return result;
        }

        [HttpPost]
        [Route("")]
        public async Task<CommentDto> CreateComment([FromBody] CommentDto commentDto)
        {
            var entity = AppMapper.Map<Comment>(commentDto);

            var result = await _commentRepository.Insert(entity);

            commentDto.Id = result;

            return commentDto;
        }
    }
}
