// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class NullWorfklowException : Exception
    {
        public NullWorfklowException()
            : base(message: "Workflow is null.")
        { }
    }
}
