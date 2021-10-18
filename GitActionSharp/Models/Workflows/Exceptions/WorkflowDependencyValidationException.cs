// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowDependencyValidationException : Exception
    {
        public WorkflowDependencyValidationException(Exception innerException)
            : base(message: "Workflow dependency validation error occurred, try again.", innerException)
        { }
    }
}
