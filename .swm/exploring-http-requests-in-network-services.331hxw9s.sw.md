---
title: Exploring HTTP Requests in Network Services
---
HTTP requests are used to communicate with external web services.

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="7:5:5" line-data="    public class HttpGetRequest : IHttpRequest">`HttpGetRequest`</SwmToken> class is responsible for making GET requests to a specified URL and returning the response as a string.

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken> class is responsible for making POST requests with a JSON payload to a specified URL and returning the response as a string.

Both <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="7:5:5" line-data="    public class HttpGetRequest : IHttpRequest">`HttpGetRequest`</SwmToken> and <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken> use the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="9:7:7" line-data="        private static readonly HttpClient Client = new HttpClient();">`HttpClient`</SwmToken> class to send HTTP requests and ensure the response status is successful.

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="11:10:10" line-data="        public async Task&lt;string&gt; ExecuteAsync(string url)">`ExecuteAsync`</SwmToken> method in both classes handles the asynchronous execution of the HTTP request and reads the response content.

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="34:5:5" line-data="        public HttpPostRequest SetData(string data)">`SetData`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken> class allows setting the JSON payload for the POST request.

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:5:5" line-data="        public HttpPostRequest SetClient(HttpClient client)">`SetClient`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken> class allows setting a custom <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="9:7:7" line-data="        private static readonly HttpClient Client = new HttpClient();">`HttpClient`</SwmToken> instance.

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="7">

---

# <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="7:5:5" line-data="    public class HttpGetRequest : IHttpRequest">`HttpGetRequest`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="7:5:5" line-data="    public class HttpGetRequest : IHttpRequest">`HttpGetRequest`</SwmToken> class is responsible for making GET requests to a specified URL and returning the response as a string. It uses the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="9:7:7" line-data="        private static readonly HttpClient Client = new HttpClient();">`HttpClient`</SwmToken> class to send HTTP requests and ensures the response status is successful.

```c#
    public class HttpGetRequest : IHttpRequest
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<string> ExecuteAsync(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="20">

---

# <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken> class is responsible for making POST requests with a JSON payload to a specified URL and returning the response as a string. It uses the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="22:3:3" line-data="        private HttpClient _client = new HttpClient();">`HttpClient`</SwmToken> class to send HTTP requests and ensures the response status is successful.

```c#
    public class HttpPostRequest : IHttpRequest
    {
        private HttpClient _client = new HttpClient();
        private string _data = "";

        public async Task<string> ExecuteAsync(string url)
        {
            var content = new StringContent(_data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        
        public HttpPostRequest SetData(string data)
        {
            this._data = data;
            return this;
        }
        
        public HttpPostRequest SetClient(HttpClient client)
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="11">

---

# <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="11:10:10" line-data="        public async Task&lt;string&gt; ExecuteAsync(string url)">`ExecuteAsync`</SwmToken> Method

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="11:10:10" line-data="        public async Task&lt;string&gt; ExecuteAsync(string url)">`ExecuteAsync`</SwmToken> method in both <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="7:5:5" line-data="    public class HttpGetRequest : IHttpRequest">`HttpGetRequest`</SwmToken> and <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken> classes handles the asynchronous execution of the HTTP request and reads the response content.

```c#
        public async Task<string> ExecuteAsync(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="34">

---

# <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="34:5:5" line-data="        public HttpPostRequest SetData(string data)">`SetData`</SwmToken> Method

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="34:5:5" line-data="        public HttpPostRequest SetData(string data)">`SetData`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="34:3:3" line-data="        public HttpPostRequest SetData(string data)">`HttpPostRequest`</SwmToken> class allows setting the JSON payload for the POST request.

```c#
        public HttpPostRequest SetData(string data)
        {
            this._data = data;
            return this;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="40">

---

# <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:5:5" line-data="        public HttpPostRequest SetClient(HttpClient client)">`SetClient`</SwmToken> Method

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:5:5" line-data="        public HttpPostRequest SetClient(HttpClient client)">`SetClient`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:3:3" line-data="        public HttpPostRequest SetClient(HttpClient client)">`HttpPostRequest`</SwmToken> class allows setting a custom <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:7:7" line-data="        public HttpPostRequest SetClient(HttpClient client)">`HttpClient`</SwmToken> instance.

```c#
        public HttpPostRequest SetClient(HttpClient client)
        {
            this._client = client;
            return this;
        }
```

---

</SwmSnippet>

# Main functions

Main functions

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="11">

---

## <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="11:10:10" line-data="        public async Task&lt;string&gt; ExecuteAsync(string url)">`ExecuteAsync`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="11:10:10" line-data="        public async Task&lt;string&gt; ExecuteAsync(string url)">`ExecuteAsync`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="7:5:5" line-data="    public class HttpGetRequest : IHttpRequest">`HttpGetRequest`</SwmToken> class handles the asynchronous execution of the HTTP GET request and reads the response content.

```c#
        public async Task<string> ExecuteAsync(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="25">

---

## <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="25:10:10" line-data="        public async Task&lt;string&gt; ExecuteAsync(string url)">`ExecuteAsync`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="25:10:10" line-data="        public async Task&lt;string&gt; ExecuteAsync(string url)">`ExecuteAsync`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="20:5:5" line-data="    public class HttpPostRequest : IHttpRequest">`HttpPostRequest`</SwmToken> class handles the asynchronous execution of the HTTP POST request and reads the response content.

```c#
        public async Task<string> ExecuteAsync(string url)
        {
            var content = new StringContent(_data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="34">

---

## <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="34:5:5" line-data="        public HttpPostRequest SetData(string data)">`SetData`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="34:5:5" line-data="        public HttpPostRequest SetData(string data)">`SetData`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="34:3:3" line-data="        public HttpPostRequest SetData(string data)">`HttpPostRequest`</SwmToken> class allows setting the JSON payload for the POST request.

```c#
        public HttpPostRequest SetData(string data)
        {
            this._data = data;
            return this;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/HttpRequest.cs" line="40">

---

## <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:5:5" line-data="        public HttpPostRequest SetClient(HttpClient client)">`SetClient`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:5:5" line-data="        public HttpPostRequest SetClient(HttpClient client)">`SetClient`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:3:3" line-data="        public HttpPostRequest SetClient(HttpClient client)">`HttpPostRequest`</SwmToken> class allows setting a custom <SwmToken path="unity/four-block/Assets/network/HttpRequest.cs" pos="40:7:7" line-data="        public HttpPostRequest SetClient(HttpClient client)">`HttpClient`</SwmToken> instance.

```c#
        public HttpPostRequest SetClient(HttpClient client)
        {
            this._client = client;
            return this;
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes" doc-type="overview"><sup>Powered by [Swimm](/)</sup></SwmMeta>
