using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string Java { get; set; }
        public string Csharp { get; set; }
        public string Ruby { get; set; }
        public string Kotlin { get; set; }
        public string Php { get; set; }
        public string Python { get; set; }
        public string NodeJs { get; set; }
        public string Javascript { get; set; }
        public string Html { get; set; }
        public string Css { get; set; }
        public string React { get; set; }
        public string C { get; set; }
        public string BancoDeDados { get; set; }
        public string Cloud { get; set; }
        public string Api { get; set; }
        public string Android { get; set; }

        // public ICollection<Question> PostsForCategory { get; set; }
    }
}