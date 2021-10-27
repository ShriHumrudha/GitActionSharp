// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class FailedWorkflowServiceException : Xeption
    {
        public FailedWorkflowServiceException(Exception innerException)
            : base(message: "Failed workflow service error occurred, contact support.", innerException)
        { }
    }
}
