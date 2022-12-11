using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WpfTable
{
    
    class Book
    {


        //public Book(int iDBook, string bookName, int count, string author)
        //{
        //    IDBook = iDBook;
        //    BookName = bookName;
        //    Count = count;
        //    Author = author;
        //}

        [Key]
        public int IDBook{get; set ;}
        public string BookName { get; set; }
        public int Count { get; set; }
        public string Author { get; set; }


    }
}
