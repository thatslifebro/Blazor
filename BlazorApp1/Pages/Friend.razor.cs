namespace BlazorApp1.Pages
{
	public class FriendListResult
	{
		public int result { get; set; }
		public IEnumerable<FriendInfo> friendList { get; set; }
	}
	public class FriendInfo
	{
		public int uid { get; set; }
		public int friend_uid { get; set; }
		public bool friend_yn { get; set; }
		public DateTime create_dt { get; set; }
	}

	public class Result
	{
		public int result { get; set; }
	}

	public class FriendUid
	{
		public int friendUid { get; set; }
	}
}
