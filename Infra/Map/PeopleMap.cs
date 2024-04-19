using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infra.Map
{
    public class PeopleMap : IEntityTypeConfiguration<PeopleEntity>
    {
        public void Configure(EntityTypeBuilder<PeopleEntity> builder)
        {
            builder.HasKey(people => people.id);
            builder.Property(people => people.fullname).IsRequired().HasMaxLength(50);
            builder.Property(people => people.dateofbirth).IsRequired();
            builder.Property(people => people.inactive).IsRequired();
            builder.Property(people => people.nationality).IsRequired();
            builder.Property(people => people.document).HasMaxLength(20);
            builder.Property(people => people.passport).HasMaxLength(20);
        }
    }
}
