using System.ComponentModel.DataAnnotations;

namespace Web_Api.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public int Marks { get; set;}
    }
}
