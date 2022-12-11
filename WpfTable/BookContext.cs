using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTable
{
    class BookContext:DbContext
    {
        public BookContext() : base("DbConnection")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<BookContext>());
        }
        public DbSet<Book> Books { get; set; }
    }
}
