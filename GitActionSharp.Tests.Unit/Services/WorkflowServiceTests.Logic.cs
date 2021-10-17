// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using GitActionSharp.Models.Workflows;
using Moq;
using Xunit;

namespace GitActionSharp.Tests.Unit.Services
{
    public partial class WorkflowServiceTests
    {
        [Fact]
        public void ShouldCreateWorkflow()
        {
            // given
            string randomDestinationPath = GetRandomDestinationPath();
            string inputDestinationPath = randomDestinationPath;
            Workflow randomWorkflow = CreateRandomWorkflow();
            Workflow inputWorkflow = randomWorkflow;
            string serialziedWorkflow = GetRandomString();

            this.yamlBrokerMock.Setup(broker =>
                broker.SerializeToYaml(inputWorkflow))
                    .Returns(serialziedWorkflow);

            // when
            this.workflowService.CreateWorkflow(
                inputDestinationPath,
                inputWorkflow);

            // then
            this.yamlBrokerMock.Verify(broker =>
                broker.SerializeToYaml(inputWorkflow),
                    Times.Once);

            this.outputBrokerMock.Verify(broker =>
                broker.GenerateFileOutput(
                    inputDestinationPath,
                    serialziedWorkflow),
                        Times.Once);

            this.yamlBrokerMock.VerifyNoOtherCalls();
            this.outputBrokerMock.VerifyNoOtherCalls();
        }
    }
}
