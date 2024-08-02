using System.Threading.Tasks;

namespace network
{
    public interface IHttpRequest
    {
        Task<string> ExecuteAsync(string url);
    }
}