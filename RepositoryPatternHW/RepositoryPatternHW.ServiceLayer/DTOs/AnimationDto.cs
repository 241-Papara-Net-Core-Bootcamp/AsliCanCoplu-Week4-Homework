using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternHW.ServiceLayer.DTOs
{
    public class AnimationDto
    {
        [Required(ErrorMessage = "Movie name is required.")]

        public string Name { get; set; }
        public string Director { get; set; }

        public string Studios { get; set; }
        public string Writer { get; set; }
        public string Stars { get; set; }
        public string BoxOffice { get; set; }
    }
}
