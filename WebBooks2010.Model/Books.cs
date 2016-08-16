using System.ComponentModel.DataAnnotations;


namespace WebBooks2010.Model
{
    public class Books
    {
        public int title_id { get; set; }

     
        public string title { get; set; }

        
        public string type { get; set; }
        public int pub_id { get; set; }
        public string price { get; set; }
        public string advance { get; set; }
        public string royalty { get; set; }
        public string ytd_sales { get; set; }
        public string notes { get; set; }
        public string pubdate { get; set; }
    }

    
}
