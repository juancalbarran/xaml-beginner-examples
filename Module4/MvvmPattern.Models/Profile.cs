using System;

namespace MvvmPattern.Models
{
    public sealed class Profile
    {
        public string FullName { get; set; }

        public int NumberOfCredentials { get; set; }

        public DateTime HireDate { get; set; }
    }
}
