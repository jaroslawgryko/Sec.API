namespace Sec.API.Model
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string Tags { get; set; }
        public string Duration { get; set; }
        public string Url { get; set; }
        public string VideoUrl { get; set; }        
    }
}