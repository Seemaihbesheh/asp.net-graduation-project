namespace WebApplication3.DBContext
{
    public interface IInvoiceContainer
    {
        Task<List<InvoiceHeader>> GetAllInvoiceHeader();
        Task<InvoiceHeader> GetAllInvoiceHeaderbyCode(string invoiceno);
    }
}
