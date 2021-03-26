using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Sarnado.ActionProvider.ActionServices.ActionApprovers.Entities
{
    internal class ActionApprover : IActionApprover
    {
        public bool IsActionApproved { get; private set; }

        private IEnumerable<IActionApproveOption> _approveOptions;

        public ActionApprover(IEnumerable<IActionApproveOption> approveOptions)
        {
            _approveOptions = approveOptions;
        }

        public async Task SendApprovesAsync()
        {
            foreach (var approveOption in _approveOptions) 
            {
                if (!approveOption.IsApproved) 
                {
                    await approveOption.SendApprove();
                }
            }
        }

        public async Task<bool> TryApprove()
        {
            if (_approveOptions.Count() > 0)
            {
                IsActionApproved = true;
            }
            else {
                IsActionApproved = false;
            }
            await Task.Run(() => 
            {
                foreach (var aproveOption in _approveOptions)
                {
                    IsActionApproved = IsActionApproved && aproveOption.IsApproved;
                }
            });

            return IsActionApproved;
        }
    }
}
