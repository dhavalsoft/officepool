using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entity
{
    public class AppUser
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string ImagePath { get; set; }
        [MaxLength(10)]
        public string TimeZone { get; set; }
        public bool Active { get; set; }
        [MaxLength(50)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}