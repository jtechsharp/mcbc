using System.Threading.Tasks;
using mcbc.Sessions.Dto;

namespace mcbc.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}

