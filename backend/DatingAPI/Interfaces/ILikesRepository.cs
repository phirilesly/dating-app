using DatingAPI.DTOs;
using DatingAPI.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DatingAPI.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}