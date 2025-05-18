namespace OSPManagementSystem.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string SerialNumber { get; set; } = "";

        public string Status { get; set; } = "Sprawny"; // Sprawny / Uszkodzony / W serwisie

        public DateTime? LastInspectionDate { get; set; }

        public ICollection<RescueAction>? RescueActions { get; set; }

        public ICollection<EquipmentUsageHistory>? UsageHistory { get; set; }
    }
}