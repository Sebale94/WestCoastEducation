using Domain.Models;

namespace WestCoast.App.Interfaces;

public interface ICourse
{
    string FetchCourses();
    void SaveCourses(string courses);
    Course GetCourse();
}
