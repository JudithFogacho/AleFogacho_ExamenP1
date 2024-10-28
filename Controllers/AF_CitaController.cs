using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AleFogacho_ExamenP1.Models;

namespace AleFogacho_ExamenP1.Controllers
{
    public class AF_CitaController : Controller
    {
        private readonly AleFogacho_ExamenP1Context _context;

        public AF_CitaController(AleFogacho_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: AF_Cita
        public async Task<IActionResult> Index()
        {
            return View(await _context.AF_Cita.ToListAsync());
        }
        public async Task<IActionResult> AF_Index()
        {
            return View(await _context.AF_Cita.ToListAsync());
        }

        // GET: AF_Cita/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aF_Cita = await _context.AF_Cita
                .FirstOrDefaultAsync(m => m.AF_CitaId == id);
            if (aF_Cita == null)
            {
                return NotFound();
            }

            return View(aF_Cita);
        }

        // GET: AF_Cita/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult AF_Create()
        {
            return View();
        }

        // POST: AF_Cita/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AF_Create([Bind("AF_CitaId,AF_FechaIngreso,AF_NombreCita,AF_Detalle,AF_ValorCita,AF_Seguro")] AF_Cita aF_Cita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aF_Cita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AF_Index));
            }
            return View(aF_Cita);
        }

        // GET: AF_Cita/Edit/5
        public async Task<IActionResult> AF_Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aF_Cita = await _context.AF_Cita.FindAsync(id);
            if (aF_Cita == null)
            {
                return NotFound();
            }
            return View(aF_Cita);
        }

        // POST: AF_Cita/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AF_Edit(int id, [Bind("AF_CitaId,AF_FechaIngreso,AF_NombreCita,AF_Detalle,AF_ValorCita,AF_Seguro")] AF_Cita aF_Cita)
        {
            if (id != aF_Cita.AF_CitaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aF_Cita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AF_CitaExists(aF_Cita.AF_CitaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AF_Index));
            }
            return View(aF_Cita);
        }

        // GET: AF_Cita/Delete/5
        public async Task<IActionResult> AF_Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aF_Cita = await _context.AF_Cita
                .FirstOrDefaultAsync(m => m.AF_CitaId == id);
            if (aF_Cita == null)
            {
                return NotFound();
            }

            return View(aF_Cita);
        }

        // POST: AF_Cita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aF_Cita = await _context.AF_Cita.FindAsync(id);
            if (aF_Cita != null)
            {
                _context.AF_Cita.Remove(aF_Cita);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AF_Index));
        }

        private bool AF_CitaExists(int id)
        {
            return _context.AF_Cita.Any(e => e.AF_CitaId == id);
        }
    }
}
