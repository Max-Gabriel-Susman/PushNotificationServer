public class LogController : ApiController
{
  public HttpResponseMessage  Post([FromBody]ApplePassServiceData.LogPayload payload)
  {
    string logStr = String.Join("; ", payload.logs;
    // Save to ApplePassAPILog SQL table
  }
 }