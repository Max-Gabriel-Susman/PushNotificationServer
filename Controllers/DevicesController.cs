using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


public class DevicesController : ApiController
{
   // GET request to webServiceURL/version/devices/deviceLibraryIdentifier/registrations/passTypeIdentifier
  [HttpGet]
  public HttpResponseMessage GetSerialNumber(string deviceLibraryIdentifier, string passTypeIdentifier)
  {
  }
// GET request to webServiceURL/version/devices/deviceLibraryIdentifier/registrations/passTypeIdentifier?passesUpdatedSince=tag
  [HttpGet]
  public HttpResponseMessage GetSerialNumber(string deviceLibraryIdentifier, string passTypeIdentifier, string passesUpdatedSince)
  {
    // For example...
    SerialNumbers lastUpdateToSerialNumDict = new SerialNumbers();
    // LastUpdated timestamp set to current datetime
    lastUpdateToSerialNumDict.lastUpdated = String.Format("{0:MM/dd/yyyy HH:mm:ss}", DateTime.Now);
    // A list of serial numbers got from database
    lastUpdateToSerialNumDict.serialNumbers = serialNumList; 
    string jsonRes = JsonConvert.SerializeObject(lastUpdateToSerialNumDict);
    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
    response.Content = new StringContent(jsonRes, Encoding.UTF8, "application/json");
    return response;
  }
// POST request to webServiceURL/version/devices/deviceLibraryIdentifier/registrations/passTypeIdentifier/serialNumber
  [HttpPost]
  public HttpResponseMessage RegisterDevice(string deviceLibraryIdentifier, string passTypeIdentifier, string serialNumber, [FromBody]ApplePassServiceData.DevicesPayload payload)
  {
     //Save to database, udpate Devices, Passes, Register table
  }
// DELETE request to webServiceURL/version/devices/deviceLibraryIdentifier/registrations/passTypeIdentifier/serialNumber
  [HttpDelete]
  public HttpResponseMessage UnRegisterDevice(string deviceLibraryIdentifier, string passTypeIdentifier, string serialNumber)
  {
    //Udpate Devices and Register table
  }
}