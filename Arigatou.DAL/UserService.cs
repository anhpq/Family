using Arigatou.DTO.Models;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace Arigatou.DAL
{
    public class UserService: Service<User>, IUserService
    {
        private readonly IRepositoryAsync<User> _repository;
        public UserService(IRepositoryAsync<User> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
