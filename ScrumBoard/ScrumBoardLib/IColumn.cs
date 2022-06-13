// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib
{
    public interface IColumn
    {
        string Name { get; set; }

        void ChangeName(string name);
        void AddTask(ITask task);
        void DeleteTask(ITask task);
        ITask GetTask(string name);
        List<ITask> GetAllTasks();
    }
}
