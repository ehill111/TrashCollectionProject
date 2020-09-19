using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollectionRiches.Data;
using TrashCollectionRiches.Views.ViewModels;

namespace TrashCollectionRiches.Controllers
{
    public class RegisterUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisterUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RegisterUser
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegisterUser.ToListAsync());
        }

        // GET: RegisterUser/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerUser = await _context.RegisterUser
                .FirstOrDefaultAsync(m => m.Email == id);
            if (registerUser == null)
            {
                return NotFound();
            }

            return View(registerUser);
        }

        // GET: RegisterUser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegisterUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Password,ConfirmPassword")] RegisterUser registerUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registerUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registerUser);
        }

        // GET: RegisterUser/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerUser = await _context.RegisterUser.FindAsync(id);
            if (registerUser == null)
            {
                return NotFound();
            }
            return View(registerUser);
        }

        // POST: RegisterUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Email,Password,ConfirmPassword")] RegisterUser registerUser)
        {
            if (id != registerUser.Email)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registerUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisterUserExists(registerUser.Email))
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
            return View(registerUser);
        }

        // GET: RegisterUser/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerUser = await _context.RegisterUser
                .FirstOrDefaultAsync(m => m.Email == id);
            if (registerUser == null)
            {
                return NotFound();
            }

            return View(registerUser);
        }

        // POST: RegisterUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var registerUser = await _context.RegisterUser.FindAsync(id);
            _context.RegisterUser.Remove(registerUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisterUserExists(string id)
        {
            return _context.RegisterUser.Any(e => e.Email == id);
        }
    }
}
