using Notes.Applications.Notes.Queries.GetNoteList;
using Notes.Tests.Common;
using Xunit;
using AutoMapper;
using Notes.Persistance;
using Shouldly;

namespace Notes.Tests.Notes.Queries
{
    [Collection("QueryCollection")]
    public class GetNoteListQueryHandlerTests
    {
        readonly NotesDbContext Context;
        readonly IMapper Mapper;

        public GetNoteListQueryHandlerTests(QueryTestFixture fixture)
        {
            Context = fixture.Context;
            Mapper = fixture.Mapper;
        }
        [Fact]
        public async Task GetNoteListQueryHandler_Success() {
            // Arrange
            var handler = new GetNoteListQueryHandler(Context, Mapper);

            // Act
            var result = await handler.Handle(
                new GetNoteListQuery
                {
                    UserId = NotesContextFactory.UserBId
                }, CancellationToken.None);
            // Assert
            result.ShouldBeOfType<NoteListVm>();
            result.Notes.Count.ShouldBe(2);
        }
    }
}
