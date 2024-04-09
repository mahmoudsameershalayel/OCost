using OCost.Core.APIDtos.AccountDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Service.Contracts
{
    public interface IAccountService
    {
        public UserDto Login(LoginDto dto);
    }
}
