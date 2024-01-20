using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MagazinAranjamenteFlorale.Models;

namespace MagazinAranjamenteFlorale.Data
{
    public class MagazinAranjamenteFloraleContext : DbContext
    {
        public MagazinAranjamenteFloraleContext (DbContextOptions<MagazinAranjamenteFloraleContext> options)
            : base(options)
        {
        }

        public DbSet<MagazinAranjamenteFlorale.Models.Order> Order { get; set; } = default!;

        public DbSet<MagazinAranjamenteFlorale.Models.Customer> Customer { get; set; }

        //Customer: Este numele proprietății și, prin urmare, numele tabelului din baza de date care este
        //mapat la această proprietate. Fiecare instanță a clasei MagazinAranjamenteFlorale.Models.Customer va reprezenta o înregistrare în această tabelă.

        //Entity Framework trebuie să mapeze entitatea de client (Customer)
        //la o tabelă în baza de date și să furnizeze metode pentru a efectua operații CRUD (Create, Read, Update, Delete) asupra acelei tabele
        public DbSet<MagazinAranjamenteFlorale.Models.Product> Product { get; set; }

        public DbSet<MagazinAranjamenteFlorale.Models.Offer> Offer { get; set; }
    }
}
