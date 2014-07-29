using System.Data.Entity.ModelConfiguration;
using EfCodeFirstWithMigrations;

namespace DataLayer
{
    public class ContactDetailMappings : EntityTypeConfiguration<ContactDetail>
    {
        public ContactDetailMappings()
        {
            this.HasKey(c => c.CustomerId);
            Property(c => c.MobilePhone).HasColumnName("CellPhone");
            HasRequired(c => c.Customer).WithOptional(cu => cu.ContactDetail);
        }
    }
}