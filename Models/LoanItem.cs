namespace LoanManagementSystemWebApi.Models
{
    public class LoanItem
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public decimal Interest { get; set; }
        public decimal EarlyPaymentFee { get; set; }
        public decimal Payout { get; set; }
    }
}