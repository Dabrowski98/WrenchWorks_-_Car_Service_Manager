using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WrenchWorks.Data;
using WrenchWorks.Models;

namespace WrenchWorks.Controllers
{
    public class VehicleController : Controller
    {
        private readonly WrenchWorksDbContext _context;

        public VehicleController(WrenchWorksDbContext context)
        {
            _context = context;
        }

        // GET: Vehicle
        public async Task<IActionResult> Index()
        {
            var wrenchWorksDbContext = _context.Vehicles.Include(v => v.BodyColorNavigation).Include(v => v.Person).Include(v => v.VinNavigation);
            return View(await wrenchWorksDbContext.ToListAsync());
        }

        // GET: Vehicle/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.BodyColorNavigation)
                .Include(v => v.Person)
                .Include(v => v.VinNavigation)
                .FirstOrDefaultAsync(m => m.Vin == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicle/Create
        public IActionResult Create()
        {
            ViewData["BodyColor"] = new SelectList(_context.BodyColors, "Color", "Color");
            ViewData["PersonId"] = new SelectList(_context.Persons, "PersonId", "PersonId");
            ViewData["Vin"] = new SelectList(_context.PowerSources, "Vin", "Vin");
            return View();
        }

        // POST: Vehicle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Vin,Maker,Model,YearOfProduction,EngineCapacity,PowerSource,EngineNo,BodyColor,PersonId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BodyColor"] = new SelectList(_context.BodyColors, "Color", "Color", vehicle.BodyColor);
            ViewData["PersonId"] = new SelectList(_context.Persons, "PersonId", "PersonId", vehicle.PersonId);
            ViewData["Vin"] = new SelectList(_context.PowerSources, "Vin", "Vin", vehicle.Vin);
            return View(vehicle);
        }

        // GET: Vehicle/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["BodyColor"] = new SelectList(_context.BodyColors, "Color", "Color", vehicle.BodyColor);
            ViewData["PersonId"] = new SelectList(_context.Persons, "PersonId", "PersonId", vehicle.PersonId);
            ViewData["Vin"] = new SelectList(_context.PowerSources, "Vin", "Vin", vehicle.Vin);
            return View(vehicle);
        }

        // POST: Vehicle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Vin,Maker,Model,YearOfProduction,EngineCapacity,PowerSource,EngineNo,BodyColor,PersonId")] Vehicle vehicle)
        {
            if (id != vehicle.Vin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.Vin))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BodyColor"] = new SelectList(_context.BodyColors, "Color", "Color", vehicle.BodyColor);
            ViewData["PersonId"] = new SelectList(_context.Persons, "PersonId", "PersonId", vehicle.PersonId);
            ViewData["Vin"] = new SelectList(_context.PowerSources, "Vin", "Vin", vehicle.Vin);
            return View(vehicle);
        }

        // GET: Vehicle/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.BodyColorNavigation)
                .Include(v => v.Person)
                .Include(v => v.VinNavigation)
                .FirstOrDefaultAsync(m => m.Vin == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Vehicles == null)
            {
                return Problem("Entity set 'WrenchWorksDbContext.Vehicles'  is null.");
            }
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(string id)
        {
          return (_context.Vehicles?.Any(e => e.Vin == id)).GetValueOrDefault();
        }
    }
}
