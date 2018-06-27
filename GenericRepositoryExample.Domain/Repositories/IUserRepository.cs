using GenericRepositoryExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Domain.Repositories
{
    public interface IUserRepository: IRepositoryBase<User>
    {
        //Agregar aqui los metodos particulares de user
        Task<IEnumerable<User>> GetBirthdayUsers();
    }
}
