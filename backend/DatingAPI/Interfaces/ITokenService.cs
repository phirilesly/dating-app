using DatingAPI.DTOs;
using System.Threading.Tasks;


namespace DatingAPI.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}