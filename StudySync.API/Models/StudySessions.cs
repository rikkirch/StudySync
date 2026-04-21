namespace StudySync.API.Models;

public class StudySession
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int DurationMinutes { get; set; }
    public string Notes { get; set; } = string.Empty;

    public Course Course { get; set; } = null!;
}