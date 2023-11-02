using BankApp.Domain.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Context
{
	public class AppDbContext : IdentityDbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Account> Accounts { get; set; }
		public DbSet<ActivityLogEntry> ActivityLogEntries { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Admin> Admins { get; set; }
		public DbSet<BillPayment> BillPayments { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Guarantor> Guarantors { get; set; }
		public DbSet<Loan> Loans { get; set; }
		public DbSet<NextOfKin> NextOfKins { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<PhoneNumber> PhoneNumbers { get; set; }
		public DbSet<Staff> Staff { get; set; }
		public DbSet<Transactions> Transactions { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
