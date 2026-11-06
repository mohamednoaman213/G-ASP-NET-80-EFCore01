using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public decimal price { get; set; }
        public int pages { get; set; }
       
        public int publishYear { get; set; }
        public bool  inStock { get; set; }


    }
}
