using System;
using System.Web;


namespace PushNotificationServer
{
    public class Global
    {
        void Application_Start(object sender, EventArgs e)
        {
        //Other stuff ...
        RouteTable.Routes.MapHttpRoute(
            name: "ApplePassDeviceApi",
            routeTemplate: "{version}/{controller}/{deviceLibraryIdentifier}/registrations/{passTypeIdentifier}/{serialNumber}"
        RouteTable.Routes.MapHttpRoute(
            name: "ApplePassDeviceApi2",
            routeTemplate: "{version}/{controller}/{deviceLibraryIdentifier}/registrations/{passTypeIdentifier}"
        );
        RouteTable.Routes.MapHttpRoute(
            name: "ApplePassPassApi",
            routeTemplate: "{version}/{controller}/{passTypeIdentifier}/{serialNumber}"
        );
        RouteTable.Routes.MapHttpRoute(
            name: "ApplePassLogApi",
            routeTemplate: "{version}/{controller}"
        );
        }
    }
}