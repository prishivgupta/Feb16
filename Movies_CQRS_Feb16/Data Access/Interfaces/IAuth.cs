using Movies_CQRS_Feb16.ModelsDTO;

namespace Movies_CQRS_Feb16.Data_Access.Interfaces
{
    public interface IAuth
    {
        public UserDTO LoginUser(UserDTO user);

        public UserDTO RegisterUser(UserDTO user);
    }
}
