using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks2010.Model;

namespace WebBooks2010.DataAccess
{
    public class BooksData : BaseDataAccess<Books>
    {
        public Books GetClient(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Book.FirstOrDefault(x => x.title_id == id);
            }
        }
    }
}