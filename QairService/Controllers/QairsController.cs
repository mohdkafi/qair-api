using Microsoft.AspNetCore.Mvc;
using QairService.DB;
using QairService.Services;
using QairService.DB.Models;
using QairService.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QairService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QairsController : ControllerBase
    {
        private QairDBContext db;
        private IMapper mapper;

        public QairsController(DBServicecs dbServicecs, IMapper _mapper)
        {
            db = dbServicecs.GetDBInstance();
            mapper = _mapper;
        }
        // GET: api/<QairsController>
        [HttpGet]
        public IEnumerable<Qair> Get()
        {
            var items = db.Qairs.ToList();
            List < Qair > result = new   List<Qair>();
            foreach(QairDTO item in items)
            {
                result.Add(mapper.Map<Qair>(item));
            };
            return result;
        }

        // GET api/<QairsController>/5
        [HttpGet("{id}")]
        public Qair Get(int id)
        {
            return mapper.Map<Qair>(db.Qairs.FirstOrDefault(x => x.Id == id));
        }

        // POST api/<QairsController>
        [HttpPost]
        public IActionResult Post([FromBody] Qair qair)
        {
            db.Qairs.Add(mapper.Map<QairDTO>(qair));
            db.SaveChanges();
            return Accepted(qair);
        }

        // PUT api/<QairsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QairsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
