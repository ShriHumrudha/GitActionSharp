// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using GitActionSharp.Models.Workflows.Exceptions;

namespace GitActionSharp.Services
{
    public partial class WorkflowService
    {
        public static void ValidateInput(string path)
        {
            if (path == null)
            {
                throw new NullPathException();
            }
        }
    }
}
