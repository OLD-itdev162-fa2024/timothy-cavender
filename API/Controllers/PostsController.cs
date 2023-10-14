using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly DataContext _context;

        //Constructor
        public PostsController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET api/posts
        /// </summary>
        /// <returns>A list posts</returns>
        [HttpGet(Name = "GetPosts")]
        public ActionResult<List<Post>> Get()
        {
            return this._context.Posts.ToList();
        }

        /// <summary>
        /// Get api/post/[id]
        /// </summary>
        /// <param name="id">Post id</param>
        /// <returns>A single post</returns>
        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Post> GetById(Guid id)
        {
            var post = this._context.Posts.Find(id);
            if(post is null)
            {
                return NotFound();
            }

            return Ok(post);
        }

    }
}