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
    public class UserService : IUserService
    {

        private readonly IBaseRepository<User> _baseRepository;

        public UserService(IBaseRepository<User> baseRepository)
        {
            _baseRepository = baseRepository;
        }


        public User Add<UserValidator>(User obj) where UserValidator : AbstractValidator<User>
        {
            Validate(obj, Activator.CreateInstance<UserValidator>());
            _baseRepository.Insert(obj);
            return obj;
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public IList<User> Get()
        {
            return _baseRepository.Select();
        }

        public User GetById(int id)
        {
            return _baseRepository.Select(id);
        }

        public User Update<UserValidator>(User obj) where UserValidator : AbstractValidator<User>
        {
            Validate(obj, Activator.CreateInstance<UserValidator>());
            _baseRepository.Update(obj);
            return obj;
        }

        private void Validate(User obj, AbstractValidator<User> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }

    }
}
