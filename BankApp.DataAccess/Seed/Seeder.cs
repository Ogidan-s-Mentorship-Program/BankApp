using BankApp.DataAccess.Context;
using BankApp.Domain.Entites;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Seed
{
    public class Seeder
    {
        public async static Task Seed(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, AppDbContext dbContext)
        {
            await SeedAccount(dbContext);
            await SeedActivtyLogEntry(dbContext);
            await SeedAddress(dbContext);
            await SeedAdmin(dbContext);
            await SeedBillPayment(dbContext);
            await SeedCustomer(dbContext);
            await SeedGuarantor(dbContext);
            await SeedLoan(dbContext);
            await SeedNextOfKin(dbContext);
            await SeedNotification(dbContext);
            await SeedPhoneNumber(dbContext);
            await SeedStaff(dbContext);
            await SeedTransactions(dbContext);
            await SeedUser(dbContext);

        }


        private static async Task SeedAccount(AppDbContext dbContext)
        {

            if (!dbContext.Accounts.Any())
            {
                var accounts = SeederHelper<Account>.GetData("Account.json");
                await dbContext.Accounts.AddRangeAsync(accounts);
                await dbContext.SaveChangesAsync();

            }
        }
        private static async Task SeedActivtyLogEntry(AppDbContext dbContext)
        {

            if (!dbContext.ActivityLogEntries.Any())
            {
                var ActivityLogEntries = SeederHelper<ActivityLogEntry>.GetData("ActivityLogEntry.json");
                await dbContext.ActivityLogEntries.AddRangeAsync(ActivityLogEntries);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedAddress(AppDbContext dbContext)
        {

            if (!dbContext.Addresses.Any())
            {
                var Addresses = SeederHelper<Address>.GetData("Address.json");
                await dbContext.Addresses.AddRangeAsync(Addresses);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedAdmin(AppDbContext dbContext)
        {

            if (!dbContext.Admins.Any())
            {
                var Admins = SeederHelper<Admin>.GetData("Admin.json");
                await dbContext.Admins.AddRangeAsync(Admins);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedBillPayment(AppDbContext dbContext)
        {

            if (!dbContext.BillPayments.Any())
            {
                var BillPayments = SeederHelper<BillPayment>.GetData("BillPayment.json");
                await dbContext.BillPayments.AddRangeAsync(BillPayments);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedCustomer(AppDbContext dbContext)
        {

            if (!dbContext.Customers.Any())
            {
                var Customers = SeederHelper<Customer>.GetData("Customer.json");
                await dbContext.Customers.AddRangeAsync(Customers);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedGuarantor(AppDbContext dbContext)
        {

            if (!dbContext.Guarantors.Any())
            {
                var Guarantors = SeederHelper<Guarantor>.GetData("Guarantor.json");
                await dbContext.Guarantors.AddRangeAsync(Guarantors);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedLoan(AppDbContext dbContext)
        {

            if (!dbContext.Loans.Any())
            {
                var Loans = SeederHelper<Loan>.GetData("Loan.json");
                await dbContext.Loans.AddRangeAsync(Loans);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedNextOfKin(AppDbContext dbContext)
        {

            if (!dbContext.NextOfKins.Any())
            {
                var NextOfKins = SeederHelper<NextOfKin>.GetData("NextOfKin.json");
                await dbContext.NextOfKins.AddRangeAsync(NextOfKins);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedNotification(AppDbContext dbContext)
        {

            if (!dbContext.Notifications.Any())
            {
                var Notifications = SeederHelper<Notification>.GetData("Notification.json");
                await dbContext.Notifications.AddRangeAsync(Notifications);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedPhoneNumber(AppDbContext dbContext)
        {

            if (!dbContext.PhoneNumbers.Any())
            {
                var PhoneNumbers = SeederHelper<PhoneNumber>.GetData("PhoneNumber.json");
                await dbContext.PhoneNumbers.AddRangeAsync(PhoneNumbers);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedStaff(AppDbContext dbContext)
        {

            if (!dbContext.Staff.Any())
            {
                var Staff = SeederHelper<Staff>.GetData("Staff.json");
                await dbContext.Staff.AddRangeAsync(Staff);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedTransactions(AppDbContext dbContext)
        {

            if (!dbContext.Transactions.Any())
            {
                var Transactions = SeederHelper<Transactions>.GetData("Transactions.json");
                await dbContext.Transactions.AddRangeAsync(Transactions);
                await dbContext.SaveChangesAsync();

            }
        }

        private static async Task SeedUser(AppDbContext dbContext)
        {

            if (!dbContext.Users.Any())
            {
                var Users = SeederHelper<User>.GetData("User.json");
                await dbContext.Users.AddRangeAsync(Users);
                await dbContext.SaveChangesAsync();

            }
        }
    }
}
