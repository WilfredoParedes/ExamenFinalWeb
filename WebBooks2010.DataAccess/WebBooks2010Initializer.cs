using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks2010.Model;

namespace WebBooks2010.DataAccess
{
    class WebBooks2010Initializer : DropCreateDatabaseAlways<WebContextDb>

    {
        protected override void Seed(WebContextDb context)
        {
            var Book = new List<Books>
            {
                   new Books { title_id=1,title = "Kokito",type = "escolar",
                pub_id=1, price = "20",advance = "ultimo", royalty = "lerf",
                ytd_sales = "dfgg", notes="ffg", pubdate="gghg"},

                new Books { title_id=2,title = "Escuela Nueva",type = "escolarship",
                pub_id=2, price = "30",advance = "ultimate", royalty = "lehf",
                ytd_sales = "drgg", notes="gfg", pubdate="ggrg"}
            };

            Book.ForEach(c => context.Book.Add(c));
            context.SaveChanges();
        }
    }
}
