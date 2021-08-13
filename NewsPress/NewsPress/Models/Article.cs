using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPress.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string AuthorId { get; set; }

        public string Text { get; set; }

        public DateTime WrittenDate { get; set; }
        public DateTime EditDate { get; set; }
        public string PictureName { get; set; }
        public string Themes { get; set; }
        public int status { get; set; }//0draft, 1published;2archived
        [NotMapped]
        [DisplayName("Image to upload")]
        public IFormFile ImageFile { get; set; }
        [NotMappedAttribute]
        [BindProperty]
        public List<int> Arechecked { get; set; }
    }
}
