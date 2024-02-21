namespace BlazorApp1.Pages
{
	public class HiveLoginModel
	{
		public string email { get; set; }
		public string password { get; set; }
	}

	public class HiveLoginResponse
	{
		public int result { get; set; }
		public int playerId { get; set; }
		public string hiveToken { get; set; }
	}
}
