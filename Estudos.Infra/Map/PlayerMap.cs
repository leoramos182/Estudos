using Estudos.Domain.Entities;
using Estudos.Infra.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estudos.Infra.Map;

public class PlayerMap: IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.ToTable("player");

        builder.MapId(x => x.Id);

        builder.MapVarchar(x => x.FirstName, "first_name", true);
    }
}