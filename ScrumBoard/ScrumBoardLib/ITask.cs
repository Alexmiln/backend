// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLib
{
    public interface ITask
    {
        string Name { get; set; }
        string Description { get; set; }
        int Priority { get; set; }

        void ChangeName(string name);
        void ChangeDescription(string description);
        void ChangePriority(int priority);
    }
}
