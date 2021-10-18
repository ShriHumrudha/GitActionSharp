// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowServiceException : Exception
    {
        public WorkflowServiceException(Exception innerException)
            : base(message: "Workflow service error occurred, contact support.", innerException)
        { }
    }
}
