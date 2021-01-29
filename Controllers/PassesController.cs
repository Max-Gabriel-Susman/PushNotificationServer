public class PassesController : ApiController
{
  public HttpResponseMessage Get(string passTypeIdentifier, string serialNumber)
  {
    // If there was new updates, re-generate the whole Pass.
    byte[] passBytes= [YourMethodToGeneratePass]([YourParameter]);
    // Return the reponse
    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
    var dataStream = new MemoryStream(passBytes);
    response.Content = new StreamContent(dataStream);
    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/vnd.apple.pkpass");
    response.Content.Headers.LastModified = DateTime.Now;
    return response;
  }
}