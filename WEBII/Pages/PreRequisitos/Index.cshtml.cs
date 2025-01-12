﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEBII;
using WEBII.Data;

namespace WEBII.Pages.PreRequisitos
{
    public class IndexModel : PageModel
    {
        private readonly WEBII.Data.ApplicationDbContext _context;

        public IndexModel(WEBII.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PreRequisito> PreRequisito { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PreRequisito != null)
            {
                PreRequisito = await _context.PreRequisito.ToListAsync();
            }
        }
    }
}
