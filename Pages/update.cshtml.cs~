using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using API;

public class ListModel : PageModel {
    /*
      Request URL for Login action
     */
    public string login_url = "/index.php?page=api&module=auth&action=login";
    public string login_method = "POST";
    public string login_request = "";

    /* 
       Request URL for List action
       For this example we using AccountsReceivable/OrderProcessing/ViewOrders Enterprise screen, but you can use any screen from list in file EnterpriseScreens.json
     */
    public string list_url = "/index.php?page=api&module=forms&path=AccountsReceivable/OrderProcessing/ViewOrders&action=list&session_id=";
    public string list_method = "GET";

    static HttpClient myAppHTTPClient = new HttpClient();

    public ListModel(){
        APIRequests();
    }

    public async void APIRequests(){
        dynamic body = new JObject();
        /*Credentials for Login request*/
        body.CompanyID = "DINOS";
        body.DivisionID = "DEFAULT";
        body.DepartmentID = "DEFAULT";
        body.EmployeeID = "Demo";
        body.EmployeePassword = "Demo";
        body.language = "english";

        /*
          Login request. Request Body is JSON, Response body is JSON
          Response is json like:
          {
          "session_id": "aud8s4l449frcnponmv1ithvoo",
          "companies": [],
          "message": "ok"
          }
          Where session_id is uuid, which used for any other API request
         */
        dynamic sessionResult = JObject.Parse(await(API.doRequest(this.login_method, this.login_url, this.login_request = body.ToString())));
        Console.WriteLine(sessionResult);
        /*
          Forms List Request.
          Getting list of all Opened Orders
         */
        Console.WriteLine(await(API.doRequest(list_method, list_url + sessionResult.session_id, null)));
    }
}
