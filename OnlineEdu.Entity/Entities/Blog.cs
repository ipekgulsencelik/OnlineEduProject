using System;

namespace OnlineEdu.Entity.Entities
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public DateTime BlogDate { get; set; }
        public int BlogCategoryID { get; set; }
        public BlogCategory BlogCategory { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}