using DataTemplate.Models;
using System.Collections.Generic;
using Windows.UI;

namespace DataTemplate.ViewModels
{
    public class ClassroomViewModel
    {
        public string ClassroomName { get; private set; }

        public List<Student> Students { get; private set; }

        public ClassroomViewModel()
        {
            ClassroomName = "Ms. Henderson's 5th Grade Class";
            Students = new List<Student>
        {
            new Student { Name = "Sidney Andrews", FavoriteColor = Colors.Gold, Age = 9 },
            new Student { Name = "Jaiden Ashby", FavoriteColor = Colors.Red, Age = 10 }
        };
        }
    }
}
