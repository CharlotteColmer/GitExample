using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GitExample.Data;
using GitExample.Models;

namespace GitExample.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly GitExample.Data.GitExampleContext _context;

        public IndexModel(GitExample.Data.GitExampleContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
