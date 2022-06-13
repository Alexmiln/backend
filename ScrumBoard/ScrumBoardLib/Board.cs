// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib
{
    public class Board : IBoard
    {
        private readonly int MAX_COLUMN_COUNTER = 10;

        public List<IColumn> Columns { get; set; }

        public string Name { get; set; }

        public Board(string name)
        {
            Name = name;
            Columns = new List<IColumn>();
        }

        public void AddColumn(string name)
        {
            if (Columns.Count < MAX_COLUMN_COUNTER)
            {
                IColumn ColumnNew = new Column(name);
                Columns.Add(ColumnNew);
            }
        }

        public void AddTask(ITask task)
        {
            IColumn column = Columns[0];
            column.AddTask(task);
        }

        public void MoveTask(IColumn columnCurr, IColumn columnNew, ITask task)
        {
            columnCurr.DeleteTask(task);
            columnNew.AddTask(task);
        }
    }

}
