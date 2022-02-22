#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesson1.Models;

namespace Lesson1.Data
{
    public class CardContext : DbContext
    {
        public CardContext (DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public DbSet<Lesson1.Models.Card> Card { get; set; }
    }
}
