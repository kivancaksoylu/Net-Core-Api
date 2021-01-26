using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApi.Model
{
    public class Categories
    {
        //tab tab
        public int Id { get; set; }
        public string Name { get; set; }

        //kitap sayısı döndürmek için kullan
        public int NumberOfBooksOfInterest { get { return booksOfInterests.Count;  } }

        public ICollection<BooksOfInterest> booksOfInterests { get; set; } = new List<BooksOfInterest>();
    }
}
