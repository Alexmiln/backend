// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib
{
    public class Column : IColumn
    {
        public string Name { get; set; }
        private readonly List<ITask> _tasks;

        public Column(string name)
        {
            Name = name;
            _tasks = new List<ITask>();
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void AddTask(ITask task)
        {
            _tasks.Add(task);
        }

        public void DeleteTask(ITask task)
        {
            _tasks.Remove(task);
        }

        public ITask GetTask(string name)
        {
            return _tasks.Find(task => task.Name == name);
        }

        public List<ITask> GetAllTasks()
        {
            return _tasks;
        }
    }
}
