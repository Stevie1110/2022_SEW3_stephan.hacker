using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Todo_listShared;

namespace Hue06.Controllers
{
    public class TodoListsController : Controller
    {
        private readonly TodoListContext _context;

        public TodoListsController(TodoListContext context)
        {
            _context = context;
        }

        // GET: TodoLists
        public async Task<IActionResult> Index()
        {
              return _context.TodoLists != null ? 
                          View(await _context.TodoLists.ToListAsync()) :
                          Problem("Entity set 'TodoListContext.TodoLists'  is null.");
        }

        // GET: TodoLists/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.TodoLists == null)
            {
                return NotFound();
            }

            var todoList = await _context.TodoLists
                .FirstOrDefaultAsync(m => m.TodoId == id);
            if (todoList == null)
            {
                return NotFound();
            }

            return View(todoList);
        }

        // GET: TodoLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TodoLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Kurzbeschreibung,Beschreibung,ErstelltAm,Fälligkeitsdatum,TodoId")] TodoList todoList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(todoList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(todoList);
        }

        // GET: TodoLists/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.TodoLists == null)
            {
                return NotFound();
            }

            var todoList = await _context.TodoLists.FindAsync(id);
            if (todoList == null)
            {
                return NotFound();
            }
            return View(todoList);
        }

        // POST: TodoLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Kurzbeschreibung,Beschreibung,ErstelltAm,Fälligkeitsdatum,TodoId")] TodoList todoList)
        {
            if (id != todoList.TodoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(todoList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoListExists(todoList.TodoId))
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
            return View(todoList);
        }

        // GET: TodoLists/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.TodoLists == null)
            {
                return NotFound();
            }

            var todoList = await _context.TodoLists
                .FirstOrDefaultAsync(m => m.TodoId == id);
            if (todoList == null)
            {
                return NotFound();
            }

            return View(todoList);
        }

        // POST: TodoLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.TodoLists == null)
            {
                return Problem("Entity set 'TodoListContext.TodoLists'  is null.");
            }
            var todoList = await _context.TodoLists.FindAsync(id);
            if (todoList != null)
            {
                _context.TodoLists.Remove(todoList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoListExists(long id)
        {
          return (_context.TodoLists?.Any(e => e.TodoId == id)).GetValueOrDefault();
        }
    }
}
