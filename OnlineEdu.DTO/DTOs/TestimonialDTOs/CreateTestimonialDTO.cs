namespace OnlineEdu.DTO.DTOs.TestimonialDTOs
{
    public class CreateTestimonialDTO
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Comment { get; set; }
        public int Star { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}