namespace OSPManagementSystem.Models
{
    public class ActionEquipment
    {
        public int ActionId { get; set; }
        public RescueAction Action { get; set; } = null!;

        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; } = null!;
    }
}