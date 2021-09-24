using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGI_MongowithAPI.Models
{
    public class BookstoreDatabaseSettings:IBookstoreDatabaseSettings
    {
     public   string BooksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
