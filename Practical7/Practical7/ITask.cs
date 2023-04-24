namespace Practical7
{
    public interface ITask
    {
        double HoursWorked { get; }
        bool IsCompleted { get; }
        IPerson Owner { get; set; }
        string TaskName { get; set; }

        void PerformedWork(double hours);
        void TaskCompolete();
    }
}