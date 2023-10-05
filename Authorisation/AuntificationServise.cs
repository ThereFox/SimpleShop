using Accounts;
using Authorisation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorisation
{
    public class AuntificationServise
    {
        private IConfirmServise _confirmServise { get; init; }


        public void StartAuthorise()
        {
        
        }
        public void Confirm(string tocken)
        {
            _confirmServise.
        }
    }
}
