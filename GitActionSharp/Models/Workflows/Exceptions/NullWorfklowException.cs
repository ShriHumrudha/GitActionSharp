// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class NullWorfklowException : Xeption
    {
        public NullWorfklowException()
            : base(message: "Workflow is null.")
        { }
    }
}
