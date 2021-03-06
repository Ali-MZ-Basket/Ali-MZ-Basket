using Accounting.Components.Domain.Model.Accounting;
using System.ServiceModel;

namespace Accounting.Components.Shared.Services
{
    [ServiceContract]
    public interface IInvoiceService
    {
        [OperationContract]
        void Register(Invoice invoice);

        [OperationContract]
        IEnumerable<Invoice> GetAll();

        [OperationContract]
        IEnumerable<Invoice> GetAll(int skip, int take);

        [OperationContract]
        Invoice GetById(Guid id);

        [OperationContract]
        void Update(Invoice invoice);

        [OperationContract]
        void Remove(Guid id);
    }
}
