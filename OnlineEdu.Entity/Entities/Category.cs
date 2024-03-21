using System.Collections.Generic;

namespace OnlineEdu.Entity.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
        public List<Course> Courses { get; set; }
    }
}