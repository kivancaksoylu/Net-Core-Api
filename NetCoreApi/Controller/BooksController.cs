using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreApi.DataSource;

//.Controller yazısını kaldır
namespace NetCoreApi
{

    //Sakın Unutma => Route İşlemini 
    [Route("api/books/")] //ağaç
    public class BooksController : Controller
    {
        //bütün metodlar ağacın dalları => metodlara ağacın ismiyle ulaşacağız

        //Categories altında git categorileri ve alt bilgilerini getir
        [HttpGet()]
        public IActionResult GetCategories()
        {
            //Oluşturduğumuz veri listesini döndürücez
            return Ok(ApiDataSource.Current.categories);
        }

        //burayı postman'de göstericem api/books/gönderdiğin değer
        [HttpGet("{Id}")]
        public IActionResult GetCategories(int Id)
        {
            var data = ApiDataSource.Current.categories.FirstOrDefault(c => c.Id == Id);

            //veri varmı kontrol et
            if (data == null)
                return NotFound();

            return Ok(data); //datayı gönder
        }

        // postman'de üstünden geçicez = api/books/author/Gönderdiğin değer
        [HttpGet("author/{Name}")]
        public IActionResult GetAuthors(string name)
        {
            var data = ApiDataSource.Current.categories.SelectMany(b=> b.booksOfInterests.Select(i => new { i.Id, i.Name, i.Author }).Where(a=> a.Author == name));

            //veri varmı kontrol et
            if (data == null)
                return NotFound();

            return Ok(data); //datayı gönder
        }
    }
}
