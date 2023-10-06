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

        //GET api/posts
        [HttpGet(Name = "GetPosts")]
        public ActionResult<List<Post>> Get()
        {
            return this._context.Posts.ToList();
        }
    }
}