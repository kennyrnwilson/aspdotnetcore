using System.Threading.Tasks;

namespace client
{
    public interface IServiceClient
    {
        Task<string> GetExample(string userName);
    }
}