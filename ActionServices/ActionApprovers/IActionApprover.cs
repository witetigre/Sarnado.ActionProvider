using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionServices.ActionApprovers
{
    internal interface IActionApprover
    {
        public bool IsActionApproved { get; }
        public Task SendApprovesAsync();
        public Task<bool> TryApprove();
    }
}
