using NetCoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApi.DataSource
{
    public class ApiDataSource
    {
        //Part 2 veri kaynağı

        //Veriyi liste halinde döndür
        public static ApiDataSource Current { get; } = new ApiDataSource();

        //kategori listesi oluştur
        public List<Categories> categories { get; set; }

        public ApiDataSource()
        {
            //Verilerde türkçe karakter kullanma, aşağıda kullandıklarını sonra değiştir
            categories = new List<Categories>()
            {
                //1. Kategori
                new Categories()
                {
                    Id = 1,
                    Name = "Macera",
                    //Liste alanı olduğu için liste gibi kullan
                    booksOfInterests = new List<BooksOfInterest>()
                    {
                        new BooksOfInterest()
                        {
                            Id = 1,
                            Name = "Kuantum Casusu",
                            Author = "David"
                        },
                        new BooksOfInterest()
                        {
                            Id=2,
                            Name = "Sahte Krallık",
                            Author = "Bardugo"
                        },
                        new BooksOfInterest()
                        {
                            Id=3,
                            Name = "Yaşam Sinyali",
                            Author = "Jose Modriges"
                        }
                    }
                },

                //2. Kategori
                new Categories()
                {
                    Id = 2,
                    Name = "Korku",
                    //Liste alanı olduğu için liste gibi kullan
                    booksOfInterests = new List<BooksOfInterest>()
                    {
                        new BooksOfInterest()
                        {
                            Id = 1,
                            Name = "Gölgeler",
                            Author = "Jack London"
                        },
                        new BooksOfInterest()
                        {
                            Id = 2,
                            Name = "Cinayet Şirketi",
                            Author = "Jack London"
                        },
                        new BooksOfInterest()
                        {
                            Id = 3,
                            Name = "Ruh Kırıcı",
                            Author = "Sebastian"
                        }
                    }
                },

                new Categories()
                {
                    Id = 3,
                    Name = "Tarih",
                    //Liste alanı olduğu için liste gibi kullan
                    booksOfInterests = new List<BooksOfInterest>()
                    {
                        new BooksOfInterest()
                        {
                            Id = 1,
                            Name = "Barbarossa",
                            Author = "İskender Pala"
                        },
                        new BooksOfInterest()
                        {
                            Id = 2,
                            Name = "Homo Deus",
                            Author = "Noah Harrari"
                        },
                        new BooksOfInterest()
                        {
                            Id = 3,
                            Name = "Sultanın Korsanları",
                            Author = "Emrah Safa"
                        }
                    }
                }

            };
        }
    }
}
