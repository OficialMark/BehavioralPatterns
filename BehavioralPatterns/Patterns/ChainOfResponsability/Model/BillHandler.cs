namespace BehavioralPatterns.Patterns.ChainOfResponsability.Model
{
    public class BillHandler : DocumentHandler
    {
        public string Name { get; set; }
        private DocumentHandler _next;

        public BillHandler() => Name = "Bill";

        public void Handle(string handle)
        {
            if (handle == Name)
            {
                Console.WriteLine($"Processing {Name}...");
            }
            else if (_next != null)
            {
                _next.Handle(handle);
            }
            else
            {
                Console.WriteLine($"Cannot process {handle}.");
            }
        }

        public DocumentHandler SetNext(DocumentHandler handle)
        {
            _next = handle;

            return _next;
        }
    }
}
