namespace OnlineEdu.Entity.Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}