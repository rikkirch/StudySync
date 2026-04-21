namespace StudySync.API.Models;

public class Course
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Semester { get; set; } = string.Empty;
    public int CreditHours { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User User { get; set; } = null!;
    public ICollection<StudySession> StudySessions { get; set; } = new List<StudySession>();
    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}