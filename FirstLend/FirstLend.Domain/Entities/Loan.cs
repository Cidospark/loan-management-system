using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLend.Domain.Entities
{
    public class Loan
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BorrowerId { get; set; }
        public Guid LoanTypeId { get; set; }
        public string Status { get; set; } = "";
        public decimal Principal { get; set; } 
        public decimal Rate { get; set; } 
        public int Term { get; set; } 
        public decimal OutstandingBalance { get; set; } 
        public decimal AmountDue { get; set; }
        public string Frequncy { get; set; } = "";
        public string NextPaymentDate { get; set; } = "";
        public string Purpose { get; set; } = "";
        public string CreatedAt { get; set; } = "";
        public string DueAt { get; set; } = "";

        public User? Borrower { get; set; }
        public LoanType? LoanType { get; set; }
    }
}