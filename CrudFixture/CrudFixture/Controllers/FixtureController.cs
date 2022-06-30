using CrudFixture.Data;
using CrudFixture.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CrudFixture.Controllers
{
    public class FixtureController : Controller
    {

        private readonly FixtureContext _context;


        public FixtureController(FixtureContext context)
        {
            _context = context;
        }
        //Http get Index
        public IActionResult Index()
        {
            IEnumerable<Fixture> listFixture = _context.Fixture;

            return View(listFixture);
        }
        //Http get Create
        public IActionResult Create()
        {
            return View();
        }
        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Create(Fixture fixture)
        {
            if (ModelState.IsValid)
            {
                _context.Fixture.Add(fixture);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var fixture = _context.Fixture.Find(id);

            if (fixture == null)
            {
                return NotFound();
            }

            return View(fixture);
        }

        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fixture fixture)
        {
            if (ModelState.IsValid)
            {
                _context.Fixture.Update(fixture);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            
            var fixture = _context.Fixture.Find(id);

            if (fixture == null)
            {
                return NotFound();
            }

            return View(fixture);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteFixture(int? id)
        {
            var fixture = _context.Fixture.Find(id);

            if (fixture == null)
            {
                return NotFound();
            }

            _context.Fixture.Remove(fixture);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        //Http get Create
        public IActionResult Plantel()
        {
            return View();
        }
        
    

    }
}
