// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;

namespace GitActionSharp.Models.Workflows.Exceptions
{
    public class NullPathException : Exception
    {
        public NullPathException()
            : base(message: "Path is null.")
        { }
    }
}
