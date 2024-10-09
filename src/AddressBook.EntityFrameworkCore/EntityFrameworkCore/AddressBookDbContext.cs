using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AddressBook.Authorization.Roles;
using AddressBook.Authorization.Users;
using AddressBook.MultiTenancy;

namespace AddressBook.EntityFrameworkCore
{
    public class AddressBookDbContext : AbpZeroDbContext<Tenant, Role, User, AddressBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Models.Person> Persons { get; set; }

        public AddressBookDbContext(DbContextOptions<AddressBookDbContext> options)
            : base(options)
        {
        }
    }
}
