
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagementApp.Data
{
    public class CourseMetaData
    {
        [Display(Name = "Course Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Code in 5 Chars")]
        public string? Code { get; set; }

        [Display(Name = "Credit Points")]
        public int? Credits { get; set; }
    }

    [ModelMetadataType(typeof(CourseMetaData))]
    public partial class Course { }
}