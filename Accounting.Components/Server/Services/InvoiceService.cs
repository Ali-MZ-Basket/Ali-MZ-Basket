using Accounting.Components.Domain.Model.Accounting;
using Accounting.Components.Shared.Services;

namespace Accounting.Components.Server.Services
{
    public class InvoiceService : IInvoiceService
    {
        public IEnumerable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetAll(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Invoice GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
