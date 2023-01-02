using System.ComponentModel.DataAnnotations;

namespace WestcoastEducation.Web.Models;


public class Classroom
{
    [Key]
    public int CourseId { get; set; }
    public string Name { get; set; } = "";
    public string Content { get; set; } = "";
    public double AvgGrade { get; set; }
    public DateTime Start { get; set; } = DateTime.Now;
    public DateTime End { get; set; } = DateTime.Now.AddDays(40);
    public string Schedule { get; set; } = "";
    public bool IsOnDistance { get; init; }
    public int TeacherId { get; set; }

    public Classroom(int teacherId, bool isOnDistance)
    {
        TeacherId = teacherId;
        IsOnDistance = isOnDistance;
    }
}