// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowDependencyValidationException : Xeption
    {
        public WorkflowDependencyValidationException(Xeption innerException)
            : base(message: "Workflow dependency validation error occurred, try again.", innerException)
        { }
    }
}
