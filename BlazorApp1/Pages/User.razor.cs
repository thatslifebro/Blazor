namespace BlazorApp1.Pages
{
	public class UID
	{
		public int uid { get; set; }
	}

	public class UserInfoResponse
	{
		public int result { get; set; }
		public UserInfo userInfo { get; set; }
	}

	public class UserInfo
	{
		public int uid { get; set; }
		public string nickname { get; set; }
		public int total_bestscore { get; set; }
		public int rank { get; set; }
	}
}
