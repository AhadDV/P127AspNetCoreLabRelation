using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class TeacherController : Controller
    {
        private readonly LabDbContext _context;

        public TeacherController(LabDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teachers.Include(x=>x.Position).ToList();
            return View(teachers);
        }

        public IActionResult Detail(int id)
        {
            Teacher teacher = _context.Teachers.Include(x=>x.Position).Include(x=>x.Skills).FirstOrDefault(x => x.Id == id);
            if (teacher == null)
                return NotFound();

            return View(teacher);
        }
    }
}
