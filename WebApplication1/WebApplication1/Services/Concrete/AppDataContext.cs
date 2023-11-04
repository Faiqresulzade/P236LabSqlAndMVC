using WebApplication1.Models;
using WebApplication1.Services.Abstract;

namespace WebApplication1.Services.Concrete
{
    public class AppDataContext : IAppDataContext
    {
        private List<Group> _groups { get; set; }
        private List<Student> _students { get; set; }



        public List<Group> GetGroupData()
        {
            _groups = new List<Group>()
            {

                new Group(){ Id=1, Name="P236"},
                new Group(){Id=2, Name="p323"}

            };
            return _groups;

        }

        public List<Student> GetStudentData()
        {
            _students = new List<Student>()
            {
                new Student(){Id=1, Name="Elnur",Surname="Qafarzade",Age=17,GroupId=1},
                new Student(){Id=2, Name="Faig",Surname="Rasulzade",Age = 21,GroupId=2},
            };
            return _students;
        }
    }
}
