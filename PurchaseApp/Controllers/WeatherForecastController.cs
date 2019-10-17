using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PurchaseApp.Models;

namespace PurchaseApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context)
        {
            this._context = context;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        //Get api/Values
        [HttpGet]
        public async Task<IActionResult> GetValues(){
        var values = await _context.Values.ToListAsync();

        return Ok(values);
        }

        //Get api/Values by ID
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetValuesById(string id){
        var values = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

        return Ok(values);
        }





    }
}
