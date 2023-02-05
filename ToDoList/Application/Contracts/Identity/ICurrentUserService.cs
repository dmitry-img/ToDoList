using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Identity
{
    public interface ICurrentUserService
    {
        string GetUserName();
        string GetId();
    }
}
