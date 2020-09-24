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
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Employee able to see default list of today's trash pickups determined by employee's zip code.
        //Need customers in employee's zip code zone.
        //Need customers with trash pickup of today.
        //Employee is able to see default list of today's trash pickups determined by employee's zip code.
        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);//Find out about this???
            var employeeOnDuty = _context.Employee.Where(e => e.IdentityUserId == userId).Single();
            var customerInZipCode = _context.Customer.Where(c => c.ZipCode == employeeOnDuty.ZipCode).ToList();
            var today = DateTime.Now.DayOfWeek.ToString();
            var customerInZipAndToday = customerInZipCode.Where(c => c.PickUpDay == today).ToList();
            var customerNoSuspend = _context.Customer.Where(c => c.SuspendStart == null);
            var specialPickUpToday = _context.Customer.Where(c => c.SpecialPickUpDate == today);
            
            return View();
        }
        //Need customers' pickup day identified.
        //Need customers grouped by pickup day.
        //Need customers in employee's zip code.
        //Need to exclude customers in suspended status.
        //Employee is able to filter customers by a particular day.
        public async Task<IActionResult> Index(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);//Find out about this???
            var employeeOnDuty = _context.Employee.Where(e => e.IdentityUserId == userId).Single();
            var customerInZipCode = _context.Customer.Where(c => c.ZipCode == employeeOnDuty.ZipCode).ToList();
            var viewDay = _context.Customer.Where(c => c.PickUpDay != null).Where(c => c.PickUpDay == employeeOnDuty.EmployeeViewDay);
             
             return View();
        }
        //Need to identify customers.
        //Employee able to confirm pickup completed.
        public async Task<IActionResult> Index(Employee employee)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);//Find out about this???
            var employeeOnDuty = _context.Employee.Where(e => e.IdentityUserId == userId).Single();
            var customerInZipCode = _context.Customer.Where(c => c.ZipCode == employeeOnDuty.ZipCode).ToList();
            var completedPickup = _context.Customer.Where(c => c.PickUpCompleted == true);
            return View();
        }
        //Employee able to confirm charges to customer.
        //GET
        public async Task<IActionResult> Edit(Employee employee)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);//Find out about this???
            var employeeOnDuty = _context.Employee.Where(e => e.IdentityUserId == userId).Single();
            var customerInZipCode = _context.Customer.Where(c => c.ZipCode == employeeOnDuty.ZipCode).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit()
        {
            _context.Customer.Where(c => c.PickUpCompleted == true);

           

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
      




    }
}
