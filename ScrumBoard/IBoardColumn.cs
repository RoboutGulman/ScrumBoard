namespace ScrumBoard
{
    public interface IBoardColumn
    {
        string ColumnName { get; }

        void AddTask(ITask task);
        void ChangeName(string newName);
        void Clear();
        void DeleteTask(ITask task);
        ITask GetTask(string taskName);
        void PrintTasks();
    }
}