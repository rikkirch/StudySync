namespace StudySync.API.Models;

public class Goal
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public int TargetMinutes { get; set; }
    public int CurrentMinutes { get; set; } = 0;
    public string Period { get; set; } = string.Empty;
    public bool IsCompleted { get; set; } = false;

    public User User { get; set; } = null!;
}