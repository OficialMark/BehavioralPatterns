namespace BehavioralPatterns.Patterns.ChainOfResponsability.Model
{
    public interface DocumentHandler
    {
        public DocumentHandler SetNext(DocumentHandler handle);

        public void Handle(string handle);
    }
}
