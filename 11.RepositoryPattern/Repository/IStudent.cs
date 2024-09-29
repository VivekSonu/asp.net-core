using _10.ModelsInASPCore.Models;

namespace _10.ModelsInASPCore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
