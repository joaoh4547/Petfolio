namespace Petfolio.Communication.Responses;
public class ResponseError
{
    public List<string> Errors { get; set; } = [];

    public bool HasErrors()
    {
        return Errors.Count > 0;
    }
}
