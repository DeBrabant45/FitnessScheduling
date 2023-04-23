using Domain.Routine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Routines;

public class RoutineConfiguration : IEntityTypeConfiguration<Routine>
{
    public void Configure(EntityTypeBuilder<Routine> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(5);

        builder.HasMany(w => w.Workouts);
        builder.Navigation(w => w.Workouts)
            .IsRequired()
            .AutoInclude();
    }
}
