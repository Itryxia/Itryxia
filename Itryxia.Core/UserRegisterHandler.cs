using Itryxia.Core.Models.UserAgg;

namespace Itryxia.Core
{
    public class UserRegisterHandler
    {
        public UserCreateResponse Craete (UserCreateRequest user)
        {
            UserCreateResponse response = new UserCreateResponse();
            response.Age = user.Age;
            response.Name = user.Name;
            response.Email = user.Email;
            response.Family = user.Family;
            response.Mobile = user.Mobile;

            return response;
        }
    }
}
