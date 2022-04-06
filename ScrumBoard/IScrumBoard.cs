namespace ScrumBoard
{
    public interface IScrumBoard
    {
        string Name { get; }

        void AddColumn(string columnName);
        void AddTask(ITask task);
        void MoveTask(string nameColumnFrom, string nameColumnTo, ITask task);
        void PrintBoard();
        int SearchColumnNumberByName(string name);
    }
}