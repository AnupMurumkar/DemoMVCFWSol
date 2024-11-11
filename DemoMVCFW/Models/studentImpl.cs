using System.Linq;

namespace DemoMVCFW.Models
{
    public class studentImpl : IStudent
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() { id = 1, name = "Anup" , age = 23 , email = "anupmurumkar@gmail.com" },
                 new Student() { id = 2, name = "Aditya" , age = 21 , email = "anupmurumkar@gmail.com" },
                  new Student() { id = 3, name = "Chirag" , age = 25 , email = "anupmurumkar@gmail.com" }


            };
        }
        public Student GetStudent(int id)
        {
            return DataSource().FirstOrDefault(x => x.id == id)??new Student();
        }
    }
}
