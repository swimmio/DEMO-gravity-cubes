using System.Net.Http;
using UnityEngine;

namespace network.score
{
    public class ScoreService
    {
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
    }
}