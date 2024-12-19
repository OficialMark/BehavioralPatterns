using BehavioralPatterns.Patterns.ChainOfResponsability.Model;

namespace BehavioralPatterns.Patterns.Executions
{
    public class ChainOfResponsabilityProcess
    {
        public static void Execute()
        {
            var handler = new InvoiceHandler();
            handler.SetNext(new ReceiptHandler()).SetNext(new BillHandler());

            handler.Handle("Invoice");
            handler.Handle("Unknown");
        }
    }
}
