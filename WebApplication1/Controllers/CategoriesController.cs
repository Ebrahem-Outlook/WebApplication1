﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public CategoriesController(AppDbContext db)
        {
            _db = db;
        }

        private readonly AppDbContext _db;

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var cats = await _db.Categories.ToListAsync();
            return Ok(cats);
        }
    }
}

