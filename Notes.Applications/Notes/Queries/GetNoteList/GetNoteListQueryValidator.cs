using FluentValidation;

namespace Notes.Applications.Notes.Queries.GetNoteList
{
    public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListQueryValidator() 
        { 
            RuleFor(x => x.UserId).NotEqual(Guid.Empty);
        }
    }
}
