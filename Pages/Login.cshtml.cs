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

public class LoginModel : PageModel {
    /*
      Request URL for Login action
     */
    public string login_url = "/index.php?page=api&module=auth&action=login";
    public string login_method = "POST";
    public string login_request = "";
    
    static HttpClient myAppHTTPClient = new HttpClient();

    public LoginModel(){
        dynamic body = new JObject();
        /*Credentials for Login request*/
        body.CompanyID = "DINOS";
        body.DivisionID = "DEFAULT";
        body.DepartmentID = "DEFAULT";
        body.EmployeeID = "Demo";
        body.EmployeePassword = "Demo";
        body.language = "english";

        /*
          doing request. Request Body is JSON, Response body is JSON
          Response is json like:
          {
          "session_id": "aud8s4l449frcnponmv1ithvoo",
          "companies": [],
          "message": "ok"
          }
          Where session_id is uuid, which used for any other API request
         */
        API.doRequest(this.login_method, this.login_url, this.login_request = body.ToString()).ContinueWith(t => t.Result);
    }
}
