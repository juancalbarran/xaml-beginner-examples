using Windows.UI;

namespace DataTemplate.Models
{
    public class Student
    {
        public string Name { get; set; }

        public Color FavoriteColor { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
