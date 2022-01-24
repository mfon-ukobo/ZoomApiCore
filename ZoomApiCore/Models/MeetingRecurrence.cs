namespace ZoomApiCore.Models
{
	public class MeetingRecurrence
	{
		public int Type { get; set; }
		public int RepeatInterval { get; set; }
		public string WeeklyDays { get; set; }
		public string MonthlyDay { get; set; }
		public string MonthlyWeek { get; set; }
		public string MonthlyWeekDay { get; set; }
		public int EndTimes { get; set; }
		public string EndDateTime { get; set; }
	}
}
