namespace Observer2
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private string _subjectState;

        // Gets or sets subject state
        public string SubjectState { get; set; }
    }
}