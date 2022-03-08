using DDDModel.Domain.Entities;
using DDDModel.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDModel.Service.Services
{
    public class UserService<User> : IBaseService<User> where User : BaseEntity
    {

        private readonly IBaseRepository<User> _baseRepository;

        public UserService(IBaseRepository<User> baseRepository)
        {
            _baseRepository = baseRepository;
        }


        public User Add<UserValidator>(User obj) where UserValidator : AbstractValidator<User>
        {
            //_baseRepository.Insert(obj);
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> Get()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User Update<UserValidator>(User obj) where UserValidator : AbstractValidator<User>
        {
            throw new NotImplementedException();
        }
    }
}
