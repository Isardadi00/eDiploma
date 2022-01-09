using eDiploma.Data.Context;
using eDiploma.Models.DTOs;

namespace eDiploma.Services
{
    public interface IDataServices
    {
        IEnumerable<UserDTO> GetAllUsers();
    }

    public class DataServices : IDataServices
    {
        private readonly DiplomaDbContext _dbContext;
        public DataServices(DiplomaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<UserDTO> GetAllUsers()
        {
            var allUsers = _dbContext.Users;
            List<UserDTO> allUsersList = new List<UserDTO>();
            foreach ( var user in allUsers)
            {
                var userDto = new UserDTO
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Age = user.Age,
                    PhoneNumber = user.PhoneNumber,
                    CreatedDate = user.CreatedDate,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                };

                allUsersList.Add(userDto);
            }
            IEnumerable<UserDTO> AllUsersReturnable = allUsersList;
            return AllUsersReturnable;
        }
    }
}