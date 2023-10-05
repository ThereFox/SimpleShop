using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorisation.Abstractions
{
    public interface IConfirmServise
    {
        public void SendConfirmMessage(AuthorisationUserInfo info);
    }
}
