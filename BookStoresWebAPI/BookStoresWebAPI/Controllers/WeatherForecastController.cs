using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            //CRUD
            using (var _context = new BookStoresDBContext())
            {
                //Publisher publisher = new Publisher();
                //publisher.PublisherName = "Egmont Book";

                //_context.Publishers.Add(publisher);

                //_context.SaveChanges();

                Publisher publisher = _context.Publishers.FirstOrDefault();
                //publisher.PublisherName = "Egmont Books";

                _context.Publishers.Remove(publisher);

                _context.SaveChanges();

                return _context.Publishers.ToList();

            }

            
        }
    }
}
