namespace DemoMVCFW.Models
{
    public interface IStudent
    {
        public List<Student> DataSource();
        public Student GetStudent(int id);
    }
}
