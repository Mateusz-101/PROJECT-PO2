namespace OSPManagementSystem.Models
{
    public class EquipmentUsageHistory
    {
        public int Id { get; set; }

        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; } = null!;

        public DateTime UsedDate { get; set; }

        public string? Notes { get; set; }
    }
}