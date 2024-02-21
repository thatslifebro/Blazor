using Microsoft.JSInterop;

public interface IGlobal
{
    public int get_uid();
    public string get_jwt();

    public void set_uid(int _uid);
    public void set_jwt(string _jwt);
}

public class Global : IGlobal
{
    private int uid;
    private string jwt;

    private IJSInProcessRuntime jsr;

    public Global(IJSInProcessRuntime _jsr)
    {
        jsr = _jsr;

        var _uid = jsr.Invoke<string>("sessionStorage.getItem", "uid");
        var _jwt = jsr.Invoke<string>("sessionStorage.getItem", "token");

        uid = uid==null ? 0 : Convert.ToInt32(_uid);
        jwt = String.IsNullOrEmpty(_jwt) ? String.Empty : _jwt;
    }

    public int get_uid()
    {
        return uid;
    }

    public string get_jwt()
    {
        return jwt;
    }

    public void set_uid(int _uid)
    {
        uid = _uid;
        jsr.InvokeVoid("sessionStorage.setItem", "uid", uid);
    }

    public void set_jwt(string _jwt)
    {
        jwt = _jwt;
        jsr.InvokeVoid("sessionStorage.setItem", "token", jwt);
    }
}