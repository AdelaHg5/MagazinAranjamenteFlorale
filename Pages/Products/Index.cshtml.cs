using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagazinAranjamenteFlorale.Data;
using MagazinAranjamenteFlorale.Models;

namespace MagazinAranjamenteFlorale.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MagazinAranjamenteFlorale.Data.MagazinAranjamenteFloraleContext _context;

        public IndexModel(MagazinAranjamenteFlorale.Data.MagazinAranjamenteFloraleContext context)
        {
            _context = context;
        }

        //Acesta este constructorul clasei IndexModel. Constructorul primește ca parametru un obiect de tip MagazinAranjamenteFlorale.Data.MagazinAranjamenteFloraleContext
        //și îl atribuie variabilei private _context. Constructorul este apelat atunci când se creează o instanță a clasei IndexModel.
        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null) //Dacă _context.Product nu este null, atunci se execută această linie de cod.
                                          //Aceasta folosește metoda ToListAsync pentru a prelua toate înregistrările din tabelul de produse
                                          //și a le încărca într-o listă. Acest proces se realizează în mod asincron folosind await, iar rezultatul este atribuit proprietății Product
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
