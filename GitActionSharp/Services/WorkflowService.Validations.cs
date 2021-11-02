// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using GitActionSharp.Models.Workflows.Exceptions;

namespace GitActionSharp.Services
{
    public partial class WorkflowService
    {
        public static void ValidateInputs(string path, object workflow)
        {
            switch (path, workflow)
            {
                case (null, _):
                    throw new NullPathException();

                case (_, null):
                    throw new NullWorfklowException();
            }
        }
    }
}
