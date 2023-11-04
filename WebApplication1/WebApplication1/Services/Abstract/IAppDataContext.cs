using WebApplication1.Models;

namespace WebApplication1.Services.Abstract
{
    public interface IAppDataContext
    {
        List<Student> GetStudentData();
        List<Group> GetGroupData();
    }
}
