﻿using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WebApi.Test;

public class FinanceFlowClassFixture : IClassFixture<CustomWebApplicationFactory>
{
    private readonly HttpClient _httpClient;
    public FinanceFlowClassFixture(CustomWebApplicationFactory webApplicationFactory)
    {
        _httpClient = webApplicationFactory.CreateClient();
    }

    protected async Task<HttpResponseMessage> DoPost(
        string requestUri,
        object request,
        string token = "")
    {
        AuthorizeRequest(token);

        return await _httpClient.PostAsJsonAsync(requestUri, request);
    }

    protected async Task<HttpResponseMessage> DoGet(
        string requestUri,
        string token)
    {
        AuthorizeRequest(token);

        return await _httpClient.GetAsync(requestUri);
    }

    protected async Task<HttpResponseMessage> DoDelete(
        string requestUri,
        string token)
    {
        AuthorizeRequest(token);

        return await _httpClient.DeleteAsync(requestUri);
    }


    private void AuthorizeRequest(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
        {
            return;
        }

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }
}
