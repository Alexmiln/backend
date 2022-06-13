using Xunit;
using System.Collections.Generic;
using ScrumBoardLib;


namespace ScrumBoardTests
{
    public class ScrumBoardTests
    {
        [Fact]
        public void Create_new_board_with_name()
        {
            IBoard newBoard = new Board("Important importance");
            List<IColumn> colmns = new();

            Assert.Equal("Important importance", newBoard.Name);
            Assert.Equal(colmns, newBoard.Columns);
        }

        [Fact]
        public void Create_new_task_with_name_and_description()
        {
            ITask task = new ScrumBoardLib.Task("Simple", "Execute the plan", 1);

            Assert.Equal("Simple", task.Name);
            Assert.Equal("Execute the plan", task.Description);
            Assert.Equal(1, task.Priority);
        }

        [Fact]
        public void Create_new_column_with_name()
        {
            IColumn column = new Column("Column name");

            Assert.Equal("Column name", column.Name);
        }

        [Fact]
        public void Change_task_name()
        {
            ITask task = new ScrumBoardLib.Task("Name", "Description task", 3);
            task.ChangeName("New name");

            Assert.Equal("New name", task.Name);
        }

        [Fact]
        public void Change_task_description()
        {
            ITask task = new ScrumBoardLib.Task("Name", "Description task", 2);
            task.ChangeDescription("New description task");

            Assert.Equal("New description task", task.Description);
        }

        [Fact]
        public void Change_task_priority()
        {
            ITask task = new ScrumBoardLib.Task("Name", "Description task", 3);
            task.ChangePriority(1);

            Assert.Equal(1, task.Priority);
        }

        [Fact]
        public void Add_new_task()
        {
            IColumn column = new Column("Column name");
            ITask task = new ScrumBoardLib.Task("Task name", "Description", 5);

            column.AddTask(task);
            ITask actualTask = column.GetTask("Task name");

            Assert.Equal(task, actualTask);
        }

        [Fact]
        public void Change_column_name()
        {
            IColumn column = new Column("Column name");

            column.ChangeName("Column name");

            Assert.Equal("Column name", column.Name);
        }

        [Fact]
        public void Delete_task_in_column()
        {
            IColumn column = new Column("Column name");
            ITask task = new ScrumBoardLib.Task("Name", "Description", 1);

            column.AddTask(task);
            column.DeleteTask(task);
            ITask aTask = column.GetTask("Name");

            Assert.NotEqual(task, aTask);
        }

        [Fact]
        public void Add_new_column()
        {
            IBoard board = new Board("Board name");

            board.AddColumn("Column first");

            Assert.Single(board.Columns);
        }

        [Fact]
        public void Add_new_task_to_first_column()
        {
            IBoard board = new Board("Board name");
            ITask task = new ScrumBoardLib.Task("Task name", "Description", 1);

            board.AddColumn("abc");
            board.AddTask(task);

            Assert.Equal(task, board.Columns[0].GetTask("Task name"));
        }

        [Fact]
        public void Move_task()
        {
            IBoard board = new Board("Board name");
            ITask task = new ScrumBoardLib.Task("Task name", "Description", 1);

            board.AddColumn("Column first");
            board.AddColumn("Column second");
            board.AddTask(task);

            Assert.Equal(task, board.Columns[0].GetTask("Task name"));
            Assert.NotEqual(task, board.Columns[1].GetTask("Task name"));

            board.MoveTask(board.Columns[0], board.Columns[1], task);

            Assert.Equal(task, board.Columns[1].GetTask("Task name"));
            Assert.NotEqual(task, board.Columns[0].GetTask("Task name"));
        }
    }
}
