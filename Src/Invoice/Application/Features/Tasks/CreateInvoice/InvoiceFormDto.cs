using CsharpKioskDemoDotnet.Shared.BitPayProperties;

namespace CsharpKioskDemoDotnet.Invoice.Application.Features.Tasks.CreateInvoice;

public class InvoiceFormDto
{
    public Design Design { get; set; }
    public string? Error { get; set; }
}