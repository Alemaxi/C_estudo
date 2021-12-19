using dotnetsln2.Data.VO;
using dotnetsln2.Models;

namespace dotnetsln2.Repository.Auth
{
    public interface IUserRepository
    {
        public User ValidateCredentials(UserVO user);
        public User ValidateCredentials(string userName);
        public bool RevokeToken(string userName);
        public User RefreshUserInfo(User user);
    }
}
