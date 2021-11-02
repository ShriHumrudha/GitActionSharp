// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

namespace GitActionSharp.Client
{
    public interface IWorkflowClient
    {
        void CreateWorkflow(string destinationPath, object workflow);
    }
}
