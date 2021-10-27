// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class FailedWorkflowDependencyValidationException : Xeption
    {
        public FailedWorkflowDependencyValidationException(Exception innerException)
            : base(message: "Failed workflow dependency validation exception, fix the error and try again.", innerException)
        { }
    }
}
