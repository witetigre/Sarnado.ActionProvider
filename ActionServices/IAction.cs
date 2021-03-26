
using DataLayer.Models;
using Sarnado.ActionProvider.ActionServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionServices
{
    public interface IAction
    {
        public int Id { get; }
        public IActor Actor { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Task TryApproveAction();
        public Task<object> Execute();
        public Task<object> Decline();
    }
}
