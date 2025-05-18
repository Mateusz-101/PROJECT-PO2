using OSPManagementSystem.Models;

public class Training
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public DateTime Date { get; set; }

    public ICollection<Firefighter>? Firefighters { get; set; }
}