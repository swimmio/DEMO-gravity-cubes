---
title: Network Services Overview
---
Network Services handle the communication between the game and external servers.

They include functionalities for making HTTP requests, such as GET and POST requests.

The <SwmToken path="unity/four-block/Assets/network/user/UserService.cs" pos="11:8:8" line-data="            var getRequest = (HttpGetRequest)httpRequestFactory.CreateHttpRequest(HttpMethod.Get);">`HttpGetRequest`</SwmToken> class is responsible for executing HTTP GET requests and returning the response as a string.

The <SwmToken path="unity/four-block/Assets/network/score/ScoreService.cs" pos="11:8:8" line-data="            var postRequest = (HttpPostRequest)httpRequestFactory.CreateHttpRequest(HttpMethod.Post);">`HttpPostRequest`</SwmToken> class handles HTTP POST requests, allowing data to be sent to the server and returning the response.

The `IHttpRequest` interface defines a contract for executing HTTP requests, ensuring consistency across different request types.

# Network Services Endpoints

<SwmSnippet path="/unity/four-block/Assets/network/score/ScoreService.cs" line="8">

---

## <SwmToken path="unity/four-block/Assets/network/score/ScoreService.cs" pos="8:5:5" line-data="        public void SubmitScore(int score)">`SubmitScore`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/score/ScoreService.cs" pos="8:5:5" line-data="        public void SubmitScore(int score)">`SubmitScore`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/score/ScoreService.cs" pos="6:5:5" line-data="    public class ScoreService">`ScoreService`</SwmToken> class is responsible for sending a player's score to the server. It creates an HTTP POST request to the endpoint <SwmToken path="unity/four-block/Assets/network/score/ScoreService.cs" pos="15:5:17" line-data="                .ExecuteAsync(&quot;https://liamlime.com/api/user/score/1&quot;);">`https://liamlime.com/api/user/score/1`</SwmToken> with the score data in the request body.

```c#
        public void SubmitScore(int score)
        {
            var httpRequestFactory = new HttpRequestFactory();
            var postRequest = (HttpPostRequest)httpRequestFactory.CreateHttpRequest(HttpMethod.Post);
            var postResponse = postRequest
                .SetData("{\"score\": "+score+"}")
                .SetClient(new HttpClient())
                .ExecuteAsync("https://liamlime.com/api/user/score/1");
            postResponse.ContinueWith(task =>
            {
                var result = postResponse.Result;
                Debug.Log(result);
            });
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/network/user/UserService.cs" line="8">

---

## <SwmToken path="unity/four-block/Assets/network/user/UserService.cs" pos="8:5:5" line-data="        public string GetUserName()">`GetUserName`</SwmToken>

The <SwmToken path="unity/four-block/Assets/network/user/UserService.cs" pos="8:5:5" line-data="        public string GetUserName()">`GetUserName`</SwmToken> method in the <SwmToken path="unity/four-block/Assets/network/user/UserService.cs" pos="6:5:5" line-data="    public class UserService">`UserService`</SwmToken> class retrieves the username of a user from the server. It sends an HTTP GET request to the endpoint <SwmToken path="unity/four-block/Assets/network/user/UserService.cs" pos="12:12:24" line-data="            var getResponse = getRequest.ExecuteAsync(&quot;https://liamlime.com/api/user/username/1&quot;);">`https://liamlime.com/api/user/username/1`</SwmToken> and returns the response.

```c#
        public string GetUserName()
        {
            var httpRequestFactory = new HttpRequestFactory();
            var getRequest = (HttpGetRequest)httpRequestFactory.CreateHttpRequest(HttpMethod.Get);
            var getResponse = getRequest.ExecuteAsync("https://liamlime.com/api/user/username/1");
            getResponse.Wait();
            var result = getResponse.Result;
            Debug.Log(result);
            return result;
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes"><sup>Powered by [Swimm](https://staging.swimm.cloud/)</sup></SwmMeta>
