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
    public class ServiceController : Controller
    {
        private readonly WrenchWorksDbContext _context;

        public ServiceController(WrenchWorksDbContext context)
        {
            _context = context;
        }

        // GET: Service
        public async Task<IActionResult> Index()
        {
            var wrenchWorksDbContext = _context.Services.Include(s => s.Customer).Include(s => s.Employee).Include(s => s.VinNavigation);
            return View(await wrenchWorksDbContext.ToListAsync());
        }

        // GET: Service/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Customer)
                .Include(s => s.Employee)
                .Include(s => s.VinNavigation)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Service/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId");
            ViewData["Vin"] = new SelectList(_context.Vehicles, "Vin", "Vin");
            return View();
        }

        // POST: Service/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,Vin,PaidOff,ServiceStartDate,ServiceEndDate,CustomerId,EmployeeId")] Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", service.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId", service.EmployeeId);
            ViewData["Vin"] = new SelectList(_context.Vehicles, "Vin", "Vin", service.Vin);
            return View(service);
        }

        // GET: Service/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", service.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId", service.EmployeeId);
            ViewData["Vin"] = new SelectList(_context.Vehicles, "Vin", "Vin", service.Vin);
            return View(service);
        }

        // POST: Service/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ServiceId,Vin,PaidOff,ServiceStartDate,ServiceEndDate,CustomerId,EmployeeId")] Service service)
        {
            if (id != service.ServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.ServiceId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", service.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId", service.EmployeeId);
            ViewData["Vin"] = new SelectList(_context.Vehicles, "Vin", "Vin", service.Vin);
            return View(service);
        }

        // GET: Service/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Customer)
                .Include(s => s.Employee)
                .Include(s => s.VinNavigation)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Service/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Services == null)
            {
                return Problem("Entity set 'WrenchWorksDbContext.Services'  is null.");
            }
            var service = await _context.Services.FindAsync(id);
            if (service != null)
            {
                _context.Services.Remove(service);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(long id)
        {
          return (_context.Services?.Any(e => e.ServiceId == id)).GetValueOrDefault();
        }
    }
}
