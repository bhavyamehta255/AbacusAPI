namespace AbacusWebAPI.Data.Payment
{
    public interface IPaymentRepository
    {
        /// <summary>
        /// Get Payment History Data
        /// </summary>
        public void GetDetails();

        /// <summary>
        /// Add Payment Details
        /// </summary>
        public void AddDetails();
    }
}
