namespace BlazorApp1.Pages
{
	public class LoginResult
	{
		public int result { get; set; }
		public int uid { get; set; }
		public string token { get; set; }
	}

	public class LoginModel
	{
		public string HiveToken { get; set; }
		public int PlayerId { get; set; }
	}

}
