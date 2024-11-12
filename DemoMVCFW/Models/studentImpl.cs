using System.Linq;

namespace DemoMVCFW.Models
{
    public class studentImpl : IStudent
    {

        public studentImpl() {

            string filepath = @"C:\Users\anupm\Downloads\logs.txt";
            string msg = $"student Repo created at : @{DateTime.Now.ToString()}";
            using (StreamWriter sw = new StreamWriter(filepath)) { 
            sw.WriteLine(msg);
            }
        }    
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
