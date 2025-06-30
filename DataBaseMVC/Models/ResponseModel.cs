namespace DataBaseMVC.Models;

public class ResponseModel
{
    public bool IsSuccess { get; set; }
    public string? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
}
public class ResponseModel<T> : ResponseModel
{
    public T Result { get; set; }
}
