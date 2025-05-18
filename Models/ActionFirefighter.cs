namespace OSPManagementSystem.Models
{
    public class ActionFirefighter
    {
        public int ActionId { get; set; }
        public RescueAction Action { get; set; } = null!;

        public int FirefighterId { get; set; }
        public Firefighter Firefighter { get; set; } = null!;
    }
}
