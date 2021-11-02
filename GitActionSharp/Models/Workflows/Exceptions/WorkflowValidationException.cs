// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowValidationException : Xeption
    {
        public WorkflowValidationException(Xeption innerException)
            : base(message: "Workflow validation exception occurred, try again.", innerException)
        { }
    }
}
