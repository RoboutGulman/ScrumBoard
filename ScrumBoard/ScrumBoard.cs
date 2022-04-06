using System;
using System.Collections.Generic;

namespace ScrumBoard
{
    public class ScrumBoard : IScrumBoard
    {
        private string _name;
        private List<IBoardColumn> columns;
        public string Name => _name;

        public ScrumBoard(string name)
        {
            _name = name;
            columns = new List<IBoardColumn>();
        }

        public void AddColumn(string columnName)
        {
            if (columns.Count < 10)
            {
                IBoardColumn newColumn = new BoardColumn(columnName);
                columns.Add(newColumn);
            }
        }

        public void AddTask(ITask task)
        {
            IBoardColumn column = columns[0];
            column.AddTask(task);
        }

        public void PrintBoard()
        {
            Console.Write($"Board Name: '{_name}' \n");
            foreach (var column in columns)
            {
                Console.Write($"Column Name: '{column.ColumnName}'. Tasks: ");
                column.PrintTasks();
                Console.Write("\n");
            }
        }
        public int SearchColumnNumberByName(string name)
        {
            return columns.FindIndex(a => a.ColumnName == name);
        }

        public void MoveTask(string nameColumnFrom, string nameColumnTo, ITask task)
        {
            int from = SearchColumnNumberByName(nameColumnFrom);
            int to = SearchColumnNumberByName(nameColumnTo);
            if (from >= 0 && to >= 0)
            {
                columns[from].DeleteTask(task);
                columns[to].AddTask(task);
            }
        }
    }
}
