using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApiForPipeline.Models;

namespace SampleApiForPipeline.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        public static List<Student> studentlist;
        public StudentApiController()
        {
            studentlist = new List<Student>();
        }

        [HttpGet]
        [Route("api/allstudents")]
        public List<Student> GetAll()
        {
            List<Student> lst = GenerateInitialData();

            return lst;
        }
        [HttpGet]
        [Route("api/student/{id}")]
        public Student  GetById(int id)
        {
            return GenerateInitialData().FirstOrDefault(e => e.StudentId.Equals(id));
        }
        [HttpGet]
        [Route("api/studentnameById/{id}")]
        public string GetNameById(int id)
        {
            Student st= GenerateInitialData().FirstOrDefault(e => e.StudentId.Equals(id));
            return st.StudentName;
        }

        [NonAction]
        public List<Student> GenerateInitialData()
        {
            studentlist.Add(new Student() { StudentId = 1, StudentName = "Ajay", Qualification = "BE", Percentage = 78 });
            studentlist.Add(new Student() { StudentId = 2, StudentName = "Anita", Qualification = "BSC", Percentage = 58 });
            studentlist.Add(new Student() { StudentId = 3, StudentName = "Divya", Qualification = "BA", Percentage = 71 });
            studentlist.Add(new Student() { StudentId = 4, StudentName = "Mahesh", Qualification = "BBA", Percentage = 6 });
            studentlist.Add(new Student() { StudentId = 5, StudentName = "Dinesh", Qualification = "BCOM", Percentage = 28 });
            studentlist.Add(new Student() { StudentId = 6, StudentName = "Meena", Qualification = "BSC", Percentage = 21 });
            studentlist.Add(new Student() { StudentId = 7, StudentName = "Kumar", Qualification = "BA", Percentage = 89 });
            return studentlist;
        }
    }
}
