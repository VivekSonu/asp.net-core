using _10.ModelsInASPCore.Models;

namespace _10.ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
              new StudentModel {rollNo = 1,Name="Kumar",Standard=11,Gender="Male"},
              new StudentModel {rollNo = 2,Name="Vivek",Standard=11,Gender="Male"},
              new StudentModel {rollNo = 3,Name="Singh",Standard=11,Gender="Male"},
            };

            //ViewData["myStudents"]=students;
        }
    }
}
