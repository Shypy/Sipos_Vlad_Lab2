﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sipos_Vlad_Lab2.Data;
using Sipos_Vlad_Lab2.Models;

namespace Sipos_Vlad_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Sipos_Vlad_Lab2.Data.Sipos_Vlad_Lab2Context _context;

        public IndexModel(Sipos_Vlad_Lab2.Data.Sipos_Vlad_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
