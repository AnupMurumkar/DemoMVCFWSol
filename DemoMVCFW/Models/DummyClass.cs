namespace DemoMVCFW.Models
{
    public class DummyClass
    {

        private readonly IStudent _student;

        public DummyClass(IStudent student)
        {
           _student = student;
        }
        public void DummyGetStudents(int id)
        {
            Student studentDetails = _student.GetStudent(id);
        }
    }
}
