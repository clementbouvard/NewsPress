using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace NewsPress.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Author class
    public class Author : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool admin { get; set; }
        public bool approved { get; set; }
        public string description { get; set; }
        public DateTime JoiningDate { get; set; }
        public string ProfilePicture { get; set; }
        [NotMapped]
        [DisplayName("Image to upload")]
        public IFormFile ImageFile { get; set; }
    }
}
