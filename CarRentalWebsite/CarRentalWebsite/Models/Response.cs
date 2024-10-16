namespace CarRentalWebsite.Data
{
    
public class Response
{
    public bool Success { get; set; } = true;
    public string Message { get; set; } = "Successful";
    public Object Data { get; set; } = null;
    public Response() { }
    public Response(bool _Success , string _Message , Object _Data)
    {
        Success = _Success;
        Message = _Message;
        Data = _Data;
    }
}
}