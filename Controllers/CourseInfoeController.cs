using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NickCollege.InfoData;
using NickCollege.Models;

namespace NickCollege.Controllers
{
    public class CourseInfoeController : Controller
    {
        private readonly CourseInfoDbContext _context;

        public CourseInfoeController(CourseInfoDbContext context)
        {
            _context = context;
        }

        // GET: CourseInfoe
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.CourseInfo.ToListAsync());
        }
        //
        // GET: CourseInfoe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseInfo = await _context.CourseInfo
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (courseInfo == null)
            {
                return NotFound();
            }

            return View(courseInfo);
        }

        // GET: CourseInfoe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseInfoe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CourseName,CourseDescribtion,Credits,grade1,grade2,grade3,grade4,grade5,grade6,grade7,grade8,grade9,grade10,average")] CourseInfo courseInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseInfo);
        }

        // GET: CourseInfoe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseInfo = await _context.CourseInfo.FindAsync(id);
            if (courseInfo == null)
            {
                return NotFound();
            }
            return View(courseInfo);
        }

        // POST: CourseInfoe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CourseName,CourseDescribtion,Credits,grade1,grade2,grade3,grade4,grade5,grade6,grade7,grade8,grade9,grade10,average")] CourseInfo courseInfo)
        {
            if (id != courseInfo.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseInfoExists(courseInfo.CourseID))
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
            return View(courseInfo);
        }

        // GET: CourseInfoe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseInfo = await _context.CourseInfo
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (courseInfo == null)
            {
                return NotFound();
            }

            return View(courseInfo);
        }

        // POST: CourseInfoe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseInfo = await _context.CourseInfo.FindAsync(id);
            _context.CourseInfo.Remove(courseInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseInfoExists(int id)
        {
            return _context.CourseInfo.Any(e => e.CourseID == id);
        }
    }
}
