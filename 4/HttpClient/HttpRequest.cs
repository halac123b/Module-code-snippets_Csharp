using System.Collections.Generic;
using UnityEngine;
using System.Net.Http;

public class HttpRequest : MonoBehaviour
{
  public async void SendRequest()
  {
    // Create a dict as form data to post
    Dictionary<string, string> postData = new()
    {
      ["Name"] = "Nguyen An"
    };

    // Create a HttpClient to make HTTP request, also as UnityWebRequest, we should use it in a using() statement
    using (HttpClient httpClient = new())
    {
      // Make Post request async
      /// FormUrlEncodedContent: parse dict to byte for uploading
      HttpResponseMessage response = await httpClient.PostAsync("api_url", new FormUrlEncodedContent(postData));
      if (response.IsSuccessStatusCode)
      {
        // Parse response content as string
        string result = await response.Content.ReadAsStringAsync();
      }
    }
  }
}
