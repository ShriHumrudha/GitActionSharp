// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

namespace GitActionSharp.Services
{
    public interface IWorkflowService
    {
        void CreateWorkflow(string destinationPath, object workflow);
    }
}
