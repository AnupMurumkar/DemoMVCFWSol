using System.ComponentModel.DataAnnotations;

namespace DemoMVCFW.Models
{
    public class Student
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public int age { get; set; }
        public string email { get; set; }

        public Student(int id , string name , int age , string email) {
            
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public Student()
        {

        }
    }
}
