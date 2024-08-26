﻿using FluentValidation;

namespace Notes.Applications.Notes.Commands.DeleteCommand
{
    public class DeleteNoteCommandValidator
        : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidator()
        {
            RuleFor(deleteNoteCommand => deleteNoteCommand.UserId).NotEqual(Guid.Empty);
            RuleFor(deleteNoteCommand => deleteNoteCommand.Id).NotEqual(Guid.Empty);
        }
    }
}
