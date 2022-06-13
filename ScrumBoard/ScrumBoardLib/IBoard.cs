// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib
{
    public interface IBoard
    {
        string Name { get; set; }
        List<IColumn> Columns { get; set; }
        void AddColumn(string name);
        void AddTask(ITask task);
        void MoveTask(IColumn columnCurr, IColumn columnNew, ITask task);
    }
}
