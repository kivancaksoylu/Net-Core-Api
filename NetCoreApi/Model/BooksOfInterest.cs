using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApi.Model
{
    public class BooksOfInterest
    {
        //category ile ilgili kitapların bilgileri
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

    }
}
