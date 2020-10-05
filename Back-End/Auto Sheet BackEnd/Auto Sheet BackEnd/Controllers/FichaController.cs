using System;
using System.Collections.Generic;
using System.Linq;
using Auto_Sheet_BackEnd.Data;
using Auto_Sheet_BackEnd.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auto_Sheet_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FichaController : ControllerBase
    {
        public readonly AutoSheetContext _context;

        public FichaController(AutoSheetContext autosheetContext)
        {
            _context = autosheetContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Ficha.ToList());
        }
    }
}
