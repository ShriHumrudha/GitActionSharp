// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowDependencyException : Exception
    {
        public WorkflowDependencyException(Exception innerException)
            : base(message: "Workflow dependency error occurred, contact support.", innerException)
        { }
    }
}
