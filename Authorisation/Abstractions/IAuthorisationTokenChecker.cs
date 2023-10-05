using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorisation.Abstractions
{
    public interface IAuthorisationTokenChecker
    {
        public void SaveTocken(AuthorisationUserInfo user);
        public bool CheckToken(string token);
    }
}
