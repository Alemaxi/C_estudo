using dotnetsln2.Data.VO;

namespace dotnetsln2.Business
{
    public interface ILoginBusiness
    {
        public TokenVO ValidateCredentials(UserVO user);
        public TokenVO ValidateCredentials(TokenVO token);
        public bool RevokeToken(string userName);
    }
}
