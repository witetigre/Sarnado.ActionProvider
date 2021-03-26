
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionHandler
{
    public interface IActionHandler
    {
        public Task<object> TryExecuteAction();
    }
}
