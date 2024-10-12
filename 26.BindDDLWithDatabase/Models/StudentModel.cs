using Microsoft.AspNetCore.Mvc.Rendering;

namespace _26.BindDDLWithDatabase.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public List<SelectListItem> StudentsList { get; set; }
    }
}
