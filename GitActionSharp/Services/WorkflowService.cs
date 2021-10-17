// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;
using GitActionSharp.Brokers.Outputs;
using GitActionSharp.Brokers.Serializers;

namespace GitActionSharp.Services
{
    public class WorkflowService : IWorkflowService
    {
        private readonly IYamlBroker yamlBroker;
        private readonly IOutputBroker outputBroker;

        public WorkflowService(
            IYamlBroker yamlBroker,
            IOutputBroker outputBroker)
        {
            this.yamlBroker = yamlBroker;
            this.outputBroker = outputBroker;
        }

        public void CreateWorkflow(string destinationPath, object workflow) =>
            throw new NotImplementedException();
    }
}
