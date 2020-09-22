using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollectionRiches.Data;
using TrashCollectionRiches.Models;

namespace TrashCollectionRiches.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer/Create
        public IActionResult Create(string FirstName, string LastName, string StreetAddress, string City, string State, int ZipCode, string Email, string Password)
        {
            Customer customer = new Customer();
            return View();
        }

        //POST: Customer/Create
        //To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,StreetAddress,City,State,ZipCode,Email,Password")] Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return View(customer);
        }

        // GET: Customer
        //Need day.
        //Need selection.
        public async Task<IActionResult> Edit(int id)
        {
            Customer customerToEdit = await _context.Customer.Where(c => c.CustomerId == id).SingleOrDefaultAsync();
            return View(customerToEdit);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
             _context.Customer.Update(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Create(int id)
        {
            Customer oneTimePickUp = new Customer();
            return View(oneTimePickUp);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer oneTimePickUp)
        {
            _context.Customer.Add(oneTimePickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {

            return View(await _context.Customer.ToListAsync());
        }

        //GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

       

        // GET: Customer/Edit/5
        //Need pickup schedule.
        //Customer needs ability to select pickup day.
        //Customer needs ability to change pickup day.
        public async Task<IActionResult> Edit(int? id)
        {
            
           

           
            return View();
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FirstName,LastName,StreetAddress,City,State,ZipCode,Email,PickUpDay,PickUpStatus,PaymentStatus")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
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
            return View(customer);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }
    }
}
