﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAPS2.Operation
{
    public interface IOperation
    {
        string ProgressTitle { get; }

        bool AllowCancel { get; }

        bool AllowBackground { get; }

        OperationStatus Status { get; }

        Task<bool> AsyncSuccess { get; }

        void Cancel();

        void WaitUntilFinished();

        event EventHandler StatusChanged;

        event EventHandler Finished;

        event EventHandler<OperationErrorEventArgs> Error;
    }
}
