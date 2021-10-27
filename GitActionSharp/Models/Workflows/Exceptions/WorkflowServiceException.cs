// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowServiceException : Xeption
    {
        public WorkflowServiceException(Xeption innerException)
            : base(message: "Workflow service error occurred, contact support.", innerException)
        { }
    }
}
