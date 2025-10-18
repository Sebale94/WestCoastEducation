using Domain.Models;

namespace WestCoast.App.Interfaces;

public interface ICourse
{
    string FetchCourses();
    void SaveCourses(IList<Course> courses);
    Course GetCourse();
  
      
    
   
}
