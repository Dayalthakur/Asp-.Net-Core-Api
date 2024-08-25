using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api.Model;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudController : ControllerBase
    {
        private readonly StudDbcontext _context;

        //readonly StudDbcontext obj = new StudDbcontext();

        public StudController(StudDbcontext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = _context.Students.ToList();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            var data = _context.Students.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentbyid(int id)
        {
            var data = _context.Students.Find(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Edit(Student model)
        {
            var data=_context.Students.Find(model.Id);
            if (data==null)
            {
                return NotFound();
            }
            data.Name=model.Name;
            data.Dept=model.Dept;
            data.Marks=model.Marks;
            _context.SaveChanges();
            return Ok(data);

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var data=_context.Students.Find(id);
            if (data == null)
            {
                return NotFound();
            }
            _context.Students.Remove(data);
            _context.SaveChanges();
            return Ok(data);
        }


    }
}
