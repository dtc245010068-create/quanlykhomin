using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLKHO1.Data;
using QLKHO1.Models;

namespace QLKHO1.Controllers
{
    public class ChiTietPhieuNhapsController : Controller
    {
        private readonly PhieuNhapDbContext _context;

        public ChiTietPhieuNhapsController(PhieuNhapDbContext context)
        {
            _context = context;
        }

        // GET: ChiTietPhieuNhaps
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiTietPhieuNhaps.ToListAsync());
        }

        // GET: ChiTietPhieuNhaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhieuNhap = await _context.ChiTietPhieuNhaps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietPhieuNhap == null)
            {
                return NotFound();
            }

            return View(chiTietPhieuNhap);
        }

        // GET: ChiTietPhieuNhaps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChiTietPhieuNhaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SoPhieuNhap,MaVatTu,MaViTri,SoLuong")] ChiTietPhieuNhap chiTietPhieuNhap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietPhieuNhap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietPhieuNhap);
        }

        // GET: ChiTietPhieuNhaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhieuNhap = await _context.ChiTietPhieuNhaps.FindAsync(id);
            if (chiTietPhieuNhap == null)
            {
                return NotFound();
            }
            return View(chiTietPhieuNhap);
        }

        // POST: ChiTietPhieuNhaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SoPhieuNhap,MaVatTu,MaViTri,SoLuong")] ChiTietPhieuNhap chiTietPhieuNhap)
        {
            if (id != chiTietPhieuNhap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietPhieuNhap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietPhieuNhapExists(chiTietPhieuNhap.Id))
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
            return View(chiTietPhieuNhap);
        }

        // GET: ChiTietPhieuNhaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhieuNhap = await _context.ChiTietPhieuNhaps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietPhieuNhap == null)
            {
                return NotFound();
            }

            return View(chiTietPhieuNhap);
        }

        // POST: ChiTietPhieuNhaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietPhieuNhap = await _context.ChiTietPhieuNhaps.FindAsync(id);
            if (chiTietPhieuNhap != null)
            {
                _context.ChiTietPhieuNhaps.Remove(chiTietPhieuNhap);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietPhieuNhapExists(int id)
        {
            return _context.ChiTietPhieuNhaps.Any(e => e.Id == id);
        }
    }
}
