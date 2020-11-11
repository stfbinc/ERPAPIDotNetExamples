using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class API {
    public static async Task<string> doRequest(string type, string getParams, string body){
        string baseUrl = "https://stfb.net/EnterpriseUniversalAPI";
        HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
        string result = "";
        Console.WriteLine("Start API Request");        
        Console.WriteLine(baseUrl + getParams);        
        try
        {
            var data = type == "POST" ? new StringContent(body, System.Text.Encoding.UTF8, "application/json") : new StringContent("");
            var client = new HttpClient();
            var response = type == "GET" ? await client.GetAsync(baseUrl + getParams) : await client.PostAsync(baseUrl + getParams, data);
            result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);            
            //Console.WriteLine(response.StatusCode);
            /*
            HttpResponseMessage responseMessage = await myAppHTTPClient.PostAsync(requestUrl, httpRequestMessage.Content);
            HttpContent content = responseMessage.Content;
            string message = await content.ReadAsStringAsync();*/
        }
        catch (HttpRequestException exception)
        {
            Console.WriteLine("An HTTP request exception occurred. {0}", exception.Message);
        }
        Console.WriteLine("End API Request");
        return result;
    }
}
