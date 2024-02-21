public class HeaderAdder : DelegatingHandler
{
    private IGlobal global;
    public HeaderAdder(IGlobal _global)
    {
        global = _global;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        string jwt = global.get_jwt();
        if (!String.IsNullOrEmpty(jwt)) request.Headers.Add("Authorization", "Bearer " + jwt);

		request.Headers.Clear();
		request.Headers.Add("AppVersion", "0.1");
		request.Headers.Add("MasterDataVersion", "0.1");
		request.Headers.Add("uid", global.get_uid().ToString());
		request.Headers.Add("token", global.get_jwt());

		return await base.SendAsync(request, cancellationToken);
    }
}