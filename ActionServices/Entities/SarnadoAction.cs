using DataLayer.Models;
using Sarnado.ActionProvider.ActionServices.ActionApprovers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionServices.Entities
{
    public class SarnadoAction : IAction
    {
      
        public int Id { get; private set; }
        public IActor Actor { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }

        private IActionApprover _actionApprover;



        public SarnadoAction(int id, IActor actor, Status status, IEnumerable<IActionApproveOption> actionApproveOption)
        {
            Id = id;
            Actor = actor ?? throw new ArgumentNullException(nameof(actor));
            Status = status;
            _actionApprover = new ActionApprovers.Entities.ActionApprover(actionApproveOption);
        }
        public SarnadoAction(IActor actor, Status status, IEnumerable<IActionApproveOption> actionApproveOption)
        {
            
            Actor = actor ?? throw new ArgumentNullException(nameof(actor));
            Status = status;
            _actionApprover = new ActionApprovers.Entities.ActionApprover(actionApproveOption);
        }

        public async Task TryApproveAction() 
        {
            bool isApproved = await _actionApprover.TryApprove();
            if (isApproved) 
            {
                Status = Status.FullAccepted;
            }
        }
        public async Task<object> Execute()
        {
            return await Actor.Execute();
        }

        public async Task<object> Decline()
        {
            return await Actor.Decline();
        }
    }
    public enum Status
    {
        Wait,
        Declined,
        UserAccepted,
        SystemAccepted,
        FullAccepted
    }
}
