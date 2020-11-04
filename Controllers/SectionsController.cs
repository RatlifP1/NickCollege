using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NickCollege.InfoData;
using NickCollege.Models;
using Microsoft.AspNetCore.Identity;
using NickCollege.Areas.Identity.Data;
using System.Web.Providers.Entities;
using DocumentFormat.OpenXml.InkML;
using AspNetCore;
using NickCollege.ViewModels;

namespace NickCollege.Controllers
{
    public class SectionsController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        public SectionsController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }





        private readonly SectionDbContext _context;

        public SectionsController(SectionDbContext context)
        {
            _context = context;
        }


        //     if (Views_Administration_ListUsers User == FirstName && @user.LastName)
        //{

        //}

        //private readonly UserManager<ApplicationUser> userManager;
        //application = Context.Application.Include(x => x.FK_SectionID)
        //     foreach (Application d in application)
        //      {
        //      foreach (Course c in d.Courses)
        //      {
        //      courseList.Add(d.Name + c.Title);
        //      }


     

        //private readonly UserManager<ApplicationUser> FK_SectionID;
        // GET: Sections
        public async Task<IActionResult> Index()
        {
            //var users = userManager.Users;
            //var viewModel = new InstructorIndexData();
            //viewModel.users = Users.Include(i => i.OfficeAssignment).Include(i => i.Courses.Select(c => c.Department)).OrderBy(i => i.LastName);

            //var section = _context.Section.Include(d => d.FK_UserID);


            return View(await _context.Section.ToListAsync());
        }
        //    {
        //        if(FK_SectionID != null)
        //        {
        //            return NotFound();
        //        }


        //        if (ModelState.IsValid)
        //{
        //    try
        //    {
        //                var section = await _context.Section
        //            .FirstOrDefaultAsync(m => m.SectionID == id);
        //                if (section == null)
        //                {
        //                    return NotFound();
        //                }

        //                return View(section);
        //            }









        /**********************************
         * 
         * orginal
         * 
    public async Task<IActionResult> Index()
        {
            return View(await _context.Section.ToListAsync());
        }
***********************************************************/











        // GET: Sections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section = await _context.Section          /***************************************/
                .FirstOrDefaultAsync(m => m.SectionID == id);
            if (section == null)
            {
                return NotFound();
            }

            return View(section);
        }

        // GET: Sections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SectionID,Location,Classroom,StartDate")] Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Add(section);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(section);
        }

        // GET: Sections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section = await _context.Section.FindAsync(id);
            if (section == null)
            {
                return NotFound();
            }
            return View(section);
        }

        // POST: Sections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SectionID,Location,Classroom,StartDate")] Section section)
        {
            if (id != section.SectionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(section);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionExists(section.SectionID))
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
            return View(section);
        }

        // GET: Sections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section = await _context.Section
                .FirstOrDefaultAsync(m => m.SectionID == id);
            if (section == null)
            {
                return NotFound();
            }

            return View(section);
        }

        // POST: Sections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var section = await _context.Section.FindAsync(id);
            _context.Section.Remove(section);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionExists(int id)
        {
            return _context.Section.Any(e => e.SectionID == id);
        }
    }
}
