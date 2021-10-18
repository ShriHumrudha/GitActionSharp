// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class WorkflowValidationException : Exception
    {
        public WorkflowValidationException(Exception innerException)
            : base(message: "Workflow validation exception occurred, try again.", innerException)
        { }
    }
}
