
using System.Net;

namespace Core.Entities;

public class ReturnModel<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T? Data { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public override string ToString()
    {
        return $"Message: {Message},\nBaşarılı mı ? : {Success},\nVeri : {Data}\n Status: {StatusCode}";
    }
}
