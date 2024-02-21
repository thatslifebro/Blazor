namespace BlazorApp1
{
	public class HiveServer
	{
		readonly HttpClient _httpClient;

		public HiveServer(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
	}
}
