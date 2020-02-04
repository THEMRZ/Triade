using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Data.EntidadesConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome).IsRequired().HasMaxLength(150);

            Property(c => c.SobreNome).IsRequired().HasMaxLength(150);

            Property(c => c.Email).IsRequired();
        }
    }
}
