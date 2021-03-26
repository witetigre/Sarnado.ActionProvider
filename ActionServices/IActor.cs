namespace Sarnado.ActionProvider.ActionServices
{
    using Sarnado.ActionProvider.ActionServices.Entities;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="IActor" />.
    /// </summary>
    public interface IActor
    {
        /// <summary>
        /// Gets the Status.
        /// </summary>
        public Status Status { get; }

        /// <summary>
        /// The Execute.
        /// </summary>
        /// <returns>The <see cref="Task{object}"/>.</returns>
        public Task<object> Execute();

        /// <summary>
        /// The Decline.
        /// </summary>
        /// <returns>The <see cref="Task{object}"/>.</returns>
        public Task<object> Decline();
    }
}
