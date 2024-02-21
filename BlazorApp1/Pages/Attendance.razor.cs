namespace BlazorApp1.Pages
{
	public class AttendanceResult
	{
		public int result { get; set; }
		public AttendanceInfo attendanceInfo { get; set; }
	}

	public class AttendanceInfo
	{
		public int uid { get; set; }
		public int attendance_cnt { get; set; }
		public string recent_attendance_dt { get; set; }
	}

	public class AttendanceRewardsResult
	{
		public int result { get; set; }
		public IEnumerable<AttendanceRewardsInfo> rewards { get; set; }
	}
	public class AttendanceRewardsInfo
	{
		public int rewardKey { get; set; }
		public IEnumerable<RewardData> rewardDatas { get; set; }
	}
    public class RewardData
    {
		public int reward_key { get; set; }
		public int reward_qty { get; set; }
		public string reward_type { get; set; }
    }
}
