// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using GitActionSharp.Brokers.Outputs;
using GitActionSharp.Brokers.Serializers;
using GitActionSharp.Services;

namespace GitActionSharp.Client
{
    public class WorkflowClient : IWorkflowClient
    {
        private readonly IWorkflowService workflowService;

        public WorkflowClient()
        {
            var yamlBroker = new YamlBroker();
            var outputBroker = new OutputBroker();

            this.workflowService = new WorkflowService(
                yamlBroker,
                outputBroker);
        }

        public void CreateWorkflow(string destinationPath, object workflow) =>
            this.workflowService.CreateWorkflow(destinationPath, workflow);
    }
}
