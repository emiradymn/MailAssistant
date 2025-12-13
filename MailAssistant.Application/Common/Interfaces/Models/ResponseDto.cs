namespace MailAssistant.Application.Common.Interfaces.Models;

public class ResponseDto<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }

    public static ResponseDto<T> SuccessResult(T data, string? message = null)
        => new ResponseDto<T> { Success = true, Message = message, Data = data };

    public static ResponseDto<T> Fail(string message)
        => new ResponseDto<T> { Success = false, Message = message };
}
