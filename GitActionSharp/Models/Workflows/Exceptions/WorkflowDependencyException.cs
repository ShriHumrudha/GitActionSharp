// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowDependencyException : Xeption
    {
        public WorkflowDependencyException(Xeption innerException)
            : base(message: "Workflow dependency error occurred, contact support.", innerException)
        { }
    }
}
