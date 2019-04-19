using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SFHCars.Data;
using SFHCars.Models;

namespace SFHCars.Controllers
{
    public class SalesPersonController : Controller
    {
        private readonly SalesPersonContext _context;

        public SalesPersonController(SalesPersonContext context)
        {
            _context = context;
        }

        // GET: SalesPerson
        public async Task<IActionResult> Index()
        {
            return View(await _context.SalesPerson.ToListAsync());
        }

        // GET: SalesPerson/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesPerson = await _context.SalesPerson
         .Include(s => s.Salespersons)
             .ThenInclude(e => e.Cars)
         .AsNoTracking()
         .SingleOrDefaultAsync(m => m.ID == id);
            if (salesPerson == null)
            {
                return NotFound();
            }

            return View(salesPerson);
        }

        // GET: SalesPerson/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST:SalesPerson/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnrollmentDate,FirstMidName,LastName")] SalesPerson salesPerson)//To Edit: bind with proper attributes 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(salesPerson);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(salesPerson);
        }

        // GET: SalesPerson/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesPerson = await _context.SalesPerson.FindAsync(id);
            if (salesPerson == null)
            {
                return NotFound();
            }
            return View(salesPerson);
        }

        // POST: SalesPerson/Edit/5

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var salesPersonToUpdate = await _context.Cars.SingleOrDefaultAsync(s => s.ID == id);
            if (await TryUpdateModelAsync<SalesPerson>(
                salesPersonToUpdate,
                "",
                s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate)) //edit with proper attributes
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(salesPersonToUpdate);
        }

        // GET: SalesPerson/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesPerson = await _context.SalesPerson
                .FirstOrDefaultAsync(m => m.ID == id);
            if (salesPerson == null)
            {
                return NotFound();
            }

            return View(salesPerson);
        }

        // POST: SalesPerson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesPerson = await _context.SalesPerson.FindAsync(id);
            _context.Branches.Remove(salesPerson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesPersonExists(int id)
        {
            return _context.SalesPerson.Any(e => e.ID == id);
        }
    }
}
