namespace OSPManagementSystem.Models
{
    public class FirefighterActivity
    {
        public string FirefighterName { get; set; }
        public int RescueActionsCount { get; set; }
        public int TrainingsCount { get; set; }
        public int SchedulesCount { get; set; }
    }

    public class ReportViewModel
    {
        public List<FirefighterActivity> FirefighterActivities { get; set; }
        public int TotalRescueActions { get; set; }
        public int TotalTrainings { get; set; }
        public int TotalSchedules { get; set; }
    }
}
