using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitap1311QuanLySach.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string NameBook { get; set; }
        public string Author { get; set; }
    
        public string Description { get; set; }
        public int Year { get; set; }
        public int Stock { get; set; }
      
     

        public int CategoryId { get; set; }
        public Category Category { get; set; }

     
    }
}