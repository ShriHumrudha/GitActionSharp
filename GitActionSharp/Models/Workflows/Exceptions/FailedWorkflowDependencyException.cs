// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class FailedWorkflowDependencyException : Xeption
    {
        public FailedWorkflowDependencyException(Exception innerException)
            : base(message: "Failed workflow dependency error occurred, contact support.", innerException)
        { }
    }
}
