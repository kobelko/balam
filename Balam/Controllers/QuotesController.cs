using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Balam.Data;
using Balam.Models;
using Microsoft.AspNetCore.Authorization;

namespace Balam.Controllers
{
    [Authorize]
    public class QuotesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuotesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Quotes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quote.ToListAsync());
        }

        // GET: Quotes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        // GET: Quotes/Create
        public IActionResult Create()
        {
            var settings = _context.Settings.OrderByDescending(x => x.Id).First();
            var model = new Quote
            {
                Date = DateTime.Now,
                DriverIncluded = true,
                GasolineIncluded = true,
                ProvisioningDays = 1,
                ApportionDays = 1,
                Days = 1,
                Profit = settings.TargetProfit,

                DriverWage = settings.DriverWage,
                DriverTravelExpenses = settings.DriverTravelExpenses,
                Passengers = settings.Passengers,
                TargetProfit = settings.TargetProfit,
                Provisioning = settings.Provisioning,
                DaysPerMonth = settings.DaysPerMonth,
                Cleaning = settings.Cleaning,
                Maintenance = settings.Maintenance,
                Taxes = settings.Taxes,
                Parking = settings.Parking,
                Fund = settings.Fund,
                Instalment = settings.Instalment,
                PhoneLine = settings.PhoneLine,
                OtherCosts = settings.OtherCosts,
                GasMileage = settings.GasMileage,
                GasPrice = settings.GasPrice
            };

            ViewBag.Settings = settings;
            return View(model);
        }

        // POST: Quotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Client,Destination,State,Days,Distance,Toll,GasolineIncluded,ApportionInstalment,ProvisioningIncluded,DriverIncluded,CalculatedCost,CalculatedPrice,FinalPrice,Profit,CompetitionPrice,Description")] Quote quote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quote);
        }

        // GET: Quotes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote.FindAsync(id);
            if (quote == null)
            {
                return NotFound();
            }
            return View(quote);
        }

        // POST: Quotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Client,Destination,State,Days,Distance,Toll,GasolineIncluded,ApportionInstalment,ProvisioningIncluded,DriverIncluded,CalculatedCost,CalculatedPrice,FinalPrice,Profit,CompetitionPrice,Description")] Quote quote)
        {
            if (id != quote.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuoteExists(quote.Id))
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
            return View(quote);
        }

        // GET: Quotes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        // POST: Quotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quote = await _context.Quote.FindAsync(id);
            _context.Quote.Remove(quote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.Id == id);
        }
    }
}
