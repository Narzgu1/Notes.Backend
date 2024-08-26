using FluentValidation;
using Notes.Application.Notes.Commands.CreateNote;

namespace Notes.Applications.Notes.Commands.CreateNote
{
    public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator() 
        {
            RuleFor(createNoteCommand =>
                createNoteCommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(createNoteCommand =>
                createNoteCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
