using System.Collections.Generic;

namespace OnlineEdu.Entity.Entities
{
    public class BlogCategory
    {
        public int BlogCategoryID { get; set; }
        public string Name { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
