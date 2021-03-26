using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionServices.ActionApprovers
{
    public interface IActionApproveOption
    {
        public bool IsApproved { get; }
        
        public Task SendApprove();
        public Task<bool> TryApproveOption(object confirmation);
    }
}
