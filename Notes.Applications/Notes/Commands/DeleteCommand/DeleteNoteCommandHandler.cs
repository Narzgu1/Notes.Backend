using MediatR;
using Notes.Applications.Interfaces;
using Notes.Applications.Common.Exceptions;
using Notes.Domain;

namespace Notes.Applications.Notes.Commands.DeleteCommand
{
    public class DeleteNoteCommandHandler
        : IRequestHandler<DeleteNoteCommand, Unit>
    {
        readonly INotesDbContext _dbcontext;

        public DeleteNoteCommandHandler(INotesDbContext dbcontext) => _dbcontext = dbcontext;
        public async Task<Unit> Handle(DeleteNoteCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbcontext.Notes
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null || entity.UserId != request.UserId) 
            { 
                throw new NotFoundException(nameof(Note), request.Id);
            }

            _dbcontext.Notes.Remove(entity);
            await _dbcontext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
