using Microsoft.AspNetCore.SignalR;
using OSPManagementSystem.Models;
using System;

public class Firefighter
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string Rank { get; set; } = "";
    public bool IsActive { get; set; } = true;

    public ICollection<Training>? Trainings { get; set; }
    public ICollection<RescueAction>? RescueActions { get; set; }
    public ICollection<Schedule>? Schedules { get; set; }
}
