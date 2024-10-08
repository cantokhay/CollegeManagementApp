using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagementApp.Data;

public class StudentMetaData
{
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Date Of Birth")]
    public DateOnly? DateOfBirth { get; set; }
}

[ModelMetadataType(typeof(StudentMetaData))]
public partial class Student{}