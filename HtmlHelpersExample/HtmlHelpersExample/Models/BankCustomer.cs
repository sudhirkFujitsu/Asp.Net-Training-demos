using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace HtmlHelpersExample.Models
{
    public class BankCustomer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BankCustomerID { get; set; }
        public string BankCustomerName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public bool ChequeBookFacility { get; set; }
        public string Country { get; set; }
        public decimal InitialDeposit { get; set; }
        public DateTime? AccountingOpeningDateAndTime { get; set; }
    }

    public class IciciBankDbContext : DbContext
    {
        public IciciBankDbContext() : base("data source=localhost\\sqlexpress; user id=sa; password=123; initial catalog=icicibank")
        {
        }

        public DbSet<BankCustomer> BankCustomers { get; set; }
    }
}



