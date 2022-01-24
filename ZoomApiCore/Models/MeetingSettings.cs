using System.Collections.Generic;

namespace ZoomApiCore.Models
{
	public class MeetingSettings
	{
		public bool HostVideo { get; set; }
		public bool ParticipantVideo { get; set; }
		public bool CnMeeting { get; set; }
		public bool InMeeting { get; set; }
		public bool JoinBeforeHost { get; set; }
		public int JbhTime { get; set; }
		public bool MuteUponEntry { get; set; }
		public bool Watermark { get; set; }
		public bool UsePmi { get; set; }
		public int ApprovalType { get; set; }
		public int RegistrationType { get; set; }
		public string Audio { get; set; }
		public string AudioRecording { get; set; }
		public string AlternativeHosts { get; set; }
		public bool CloseRegistration { get; set; }
		public bool WaitingRoom { get; set; }
		public IEnumerable<string> GlobalDialInCountries { get; set; }
		public string ContactName { get; set; }
		public string ContactEmail { get; set; }
		public bool RegistrantsEmailNotification { get; set; }
		public bool RegistrantsConfirmationEmail { get; set; }
		public bool MeetingAuthentication { get; set; }
		public string AuthenticationOption { get; set; }
		public string AuthenticationDomains { get; set; }
		public string AuthenticationName { get; set; }
		public bool ShowShareButtton { get; set; }
		public bool AllowMultipleDevices { get; set; }
		public string EncryptionType { get; set; }
		public bool AlternativeHostsEmailNotification { get; set; }
		public bool FocusMode { get; set; }
		public bool PrivateMeeting { get; set; }
		public bool CalendarType { get; set; }
	}
}
