// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using GitActionSharp.Brokers.Outputs;
using GitActionSharp.Brokers.Serializers;
using GitActionSharp.Models.Workflows;
using GitActionSharp.Services;
using Moq;
using Tynamix.ObjectFiller;

namespace GitActionSharp.Tests.Unit.Services
{
    public partial class WorkflowServiceTests
    {
        private readonly Mock<IYamlBroker> yamlBrokerMock;
        private readonly Mock<IOutputBroker> outputBrokerMock;
        private readonly IWorkflowService workflowService;

        public WorkflowServiceTests()
        {
            this.yamlBrokerMock = new Mock<IYamlBroker>();
            this.outputBrokerMock = new Mock<IOutputBroker>();

            this.workflowService = new WorkflowService(
                yamlBroker: this.yamlBrokerMock.Object,
                outputBroker: this.outputBrokerMock.Object);
        }

        private static string GetRandomDestinationPath() =>
            new MnemonicString().GetValue();

        private static string GetRandomString() =>
            new MnemonicString().GetValue();

        private static Workflow CreateRandomWorkflow() =>
            CreateWorkflowFiller().Create();

        private static Filler<Workflow> CreateWorkflowFiller() =>
            new Filler<Workflow>();
    }
}
