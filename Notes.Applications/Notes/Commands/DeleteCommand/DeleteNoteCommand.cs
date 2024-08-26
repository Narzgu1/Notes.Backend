using MediatR;

namespace Notes.Applications.Notes.Commands.DeleteCommand
{
    public class DeleteNoteCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
