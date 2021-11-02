// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using Xeptions;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class NullPathException : Xeption
    {
        public NullPathException()
            : base(message: "Path is null.")
        { }
    }
}
