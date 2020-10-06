using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        //Customer able to enter information and sign up to start receiving regular trash pickups.
        // GET: Customer/Create
        public IActionResult Create()
        {
            Customer customer = new Customer();
            return View();
        }
        //POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,StreetAddress,City,State,ZipCode,Email,Password")] Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return View(customer);
        }
        //Customer able to select or change weekly pickup day.
        // GET: Customer
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
        //Customer able to request extra, one-time pickup for specific date.
        public async Task<IActionResult> Create(int id)
        {
            Customer oneTimePickUp = new Customer();
            oneTimePickUp = await _context.Customer.Where(c => c.CustomerId == id).SingleOrDefaultAsync();
            return View(oneTimePickUp);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer oneTimePickUp, int id)
        {
            _context.Customer.Add(oneTimePickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //Customer able to see how much is owed.
        //GET: Customer/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Customer Balance = _context.Customer.Where(b => b.Balance == id).SingleOrDefault();
            return View(Balance);
        }
        //Customer able to specify START and END date.
        // GET: Customer
        public async Task<IActionResult> Edit(int id, DateTime suspend)
        {
            Customer suspendStartStop = _context.Customer.Where(s => s.CustomerId == id).SingleOrDefault();
            return View(await _context.Customer.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Customer suspendStartStop)
        {
            _context.Customer.Update(suspendStartStop);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }

}

