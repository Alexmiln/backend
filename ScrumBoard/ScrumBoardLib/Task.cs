// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib
{
    public class Task : ITask
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public Task(string name, string description, int priority)
        {
            Name = name;
            Description = description;
            Priority = priority;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
        }

        public void ChangePriority(int priority)
        {
            Priority = priority;
        }
    }
}
