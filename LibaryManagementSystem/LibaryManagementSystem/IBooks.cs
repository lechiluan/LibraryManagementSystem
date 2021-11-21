using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagementSystem
{
    interface IBooks
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string YearPublished { get; set; }
        public string Edition { get; set; }
        public int Price { get; set; }
        public string CategoryID { get; set; }
        public string AuthorID { get; set; }
        public string PublisherID { get; set; }
    }
}
