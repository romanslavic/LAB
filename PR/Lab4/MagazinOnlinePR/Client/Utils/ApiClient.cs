using Newtonsoft.Json;

namespace Client.Utils;

public class ApiClient
{
    private readonly HttpClient _client;

    public ApiClient(string baseUrl)
    {
        _client = new HttpClient { BaseAddress = new Uri(baseUrl) };
    }

    public async Task<T> GetAsync<T>(string uri)
    {
        var response = await _client.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<T>(response);
    }

    public async Task<HttpResponseMessage> PostAsync(string uri, object content)
    {
        var jsonContent = new StringContent(JsonConvert.SerializeObject(content), System.Text.Encoding.UTF8, "application/json");
        return await _client.PostAsync(uri, jsonContent);
    }

    public async Task<HttpResponseMessage> PutAsync(string uri, object content)
    {
        var jsonContent = new StringContent(JsonConvert.SerializeObject(content), System.Text.Encoding.UTF8, "application/json");
        return await _client.PutAsync(uri, jsonContent);
    }

    public async Task<HttpResponseMessage> DeleteAsync(string uri)
    {
        return await _client.DeleteAsync(uri);
    }
}