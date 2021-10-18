// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;
using FluentAssertions;
using GitActionSharp.Models.Workflows;
using GitActionSharp.Models.Workflows.Exceptions;
using Moq;
using Xunit;

namespace GitActionSharp.Tests.Unit.Services
{
    public partial class WorkflowServiceTests
    {
        [Fact]
        public void ShouldThrowValidationExceptionOnCreateIfDestinationPathIsNull()
        {
            // given
            string nullDestinationPath = null;
            Workflow someWorkflow = CreateRandomWorkflow();
            var nullPathException = new NullPathException();

            // when
            Action createWorkflowAction = () =>
                this.workflowService.CreateWorkflow(
                    nullDestinationPath,
                    someWorkflow);

            // then
            WorkflowValidationException actualWorkflowValidationException =
                Assert.Throws<WorkflowValidationException>(
                    createWorkflowAction);

            actualWorkflowValidationException.InnerException.Message.Should()
                .BeEquivalentTo(nullPathException.Message);

            this.yamlBrokerMock.Verify(broker =>
                broker.SerializeToYaml(It.IsAny<object>()),
                    Times.Never);

            this.outputBrokerMock.Verify(broker =>
                broker.GenerateFileOutput(It.IsAny<string>(), It.IsAny<string>()),
                    Times.Never);

            this.yamlBrokerMock.VerifyNoOtherCalls();
            this.outputBrokerMock.VerifyNoOtherCalls();
        }
    }
}
