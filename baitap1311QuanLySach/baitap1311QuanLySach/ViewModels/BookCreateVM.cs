using baitap1311QuanLySach.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitap1311QuanLySach.ViewModels
{
    public class BookCreateVM
    {

        public Book Book { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }

      
    }
}