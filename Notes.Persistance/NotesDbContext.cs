using Microsoft.EntityFrameworkCore;
using Notes.Applications.Interfaces;
using Notes.Domain;
using Notes.Persistance.EntityTypeConfiguration;

namespace Notes.Persistance
{
    public class NotesDbContext : DbContext, INotesDbContext 
    {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
