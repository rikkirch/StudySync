namespace StudySync.API.Models;

public class Grade
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string AssignmentName { get; set; } = string.Empty;
    public float Score { get; set; }
    public float MaxScore { get; set; }
    public string GradeType { get; set; } = string.Empty;

    public Course Course { get; set; } = null!;
}