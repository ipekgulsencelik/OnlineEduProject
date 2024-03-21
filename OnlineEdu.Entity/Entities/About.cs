using System.Collections.Generic;

namespace OnlineEdu.Entity.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageURL1 { get; set; }
        public string ImageURL2 { get; set; }
        public List<Feature> Services { get; set; }
    }
}
