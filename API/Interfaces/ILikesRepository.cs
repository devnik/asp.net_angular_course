using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
using API.Entities;
using API.Helper;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDTO>> GetUserLikes(LikesParams likesParams); // predicate = either list of likes or list of liked by
        Task<bool> SaveAllAsync();
    }
}