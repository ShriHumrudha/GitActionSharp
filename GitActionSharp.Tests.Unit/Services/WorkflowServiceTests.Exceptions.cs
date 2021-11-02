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
        [Theory]
        [MemberData(nameof(FileValidationExceptions))]
        public void ShouldThrowDependencyValidationOnCreateIfDependencyValidationErrorOccurs(
            Exception dependencyValidationException)
        {
            // given
            Workflow someWorkflow = CreateRandomWorkflow();
            string somePath = GetRandomDestinationPath();

            var failedWorkflowDependencyValidationException =
                new FailedWorkflowDependencyValidationException(
                    dependencyValidationException);

            var expectedWorkflowDependencyValidationException =
                new WorkflowDependencyValidationException(
                    failedWorkflowDependencyValidationException);

            this.yamlBrokerMock.Setup(broker =>
                broker.SerializeToYaml(It.IsAny<object>()))
                    .Throws(dependencyValidationException);

            // when
            Action createWorkflowAction = () =>
                this.workflowService.CreateWorkflow(
                    somePath,
                    someWorkflow);

            // then
            WorkflowDependencyValidationException actualworkflowDependencyValidationException =
                Assert.Throws<WorkflowDependencyValidationException>(
                    createWorkflowAction);

            SameExceptionAs(
                actualworkflowDependencyValidationException,
                expectedWorkflowDependencyValidationException)
                    .Should().BeTrue();

            this.yamlBrokerMock.Verify(broker =>
                broker.SerializeToYaml(It.IsAny<object>()),
                    Times.Once);

            this.outputBrokerMock.Verify(broker =>
                broker.GenerateFileOutput(It.IsAny<string>(), It.IsAny<string>()),
                    Times.Never);

            this.yamlBrokerMock.VerifyNoOtherCalls();
            this.outputBrokerMock.VerifyNoOtherCalls();
        }

        [Theory]
        [MemberData(nameof(FileDependencyExceptions))]
        public void ShouldThrowDependencyExceptionOnCreateIfDependencyErrorOccurs(
            Exception dependencyException)
        {
            // given
            Workflow someWorkflow = CreateRandomWorkflow();
            string somePath = GetRandomDestinationPath();

            var failedWorkflowDependencyException =
                new FailedWorkflowDependencyException(
                    dependencyException);

            var expectedWorkflowDependencyException =
                new WorkflowDependencyException(
                    failedWorkflowDependencyException);

            this.yamlBrokerMock.Setup(broker =>
                broker.SerializeToYaml(It.IsAny<object>()))
                    .Throws(dependencyException);

            // when
            Action createWorkflowAction = () =>
                this.workflowService.CreateWorkflow(
                    somePath,
                    someWorkflow);

            // then
            WorkflowDependencyException actualworkflowDependencyException =
                Assert.Throws<WorkflowDependencyException>(
                    createWorkflowAction);

            SameExceptionAs(
                actualworkflowDependencyException,
                expectedWorkflowDependencyException)
                    .Should().BeTrue();

            this.yamlBrokerMock.Verify(broker =>
                broker.SerializeToYaml(It.IsAny<object>()),
                    Times.Once);

            this.outputBrokerMock.Verify(broker =>
                broker.GenerateFileOutput(It.IsAny<string>(), It.IsAny<string>()),
                    Times.Never);

            this.yamlBrokerMock.VerifyNoOtherCalls();
            this.outputBrokerMock.VerifyNoOtherCalls();
        }

        [Fact]
        public void ShouldThrowServiceExceptionOnCreateIfExceptionOccurs()
        {
            // given
            Workflow someWorkflow = CreateRandomWorkflow();
            string somePath = GetRandomDestinationPath();
            string someMessage = GetRandomString();
            var exception = new Exception(someMessage);

            var failedWorkflowServiceException =
                new FailedWorkflowServiceException(exception);

            var expectedWorkflowServiceException =
                new WorkflowServiceException(
                    failedWorkflowServiceException);

            this.yamlBrokerMock.Setup(broker =>
                broker.SerializeToYaml(It.IsAny<object>()))
                    .Throws(exception);

            // when
            Action createWorkflowAction = () =>
                this.workflowService.CreateWorkflow(
                    somePath,
                    someWorkflow);

            // then
            WorkflowServiceException actualworkflowServiceException =
                Assert.Throws<WorkflowServiceException>(
                    createWorkflowAction);

            SameExceptionAs(
                actualworkflowServiceException,
                expectedWorkflowServiceException)
                    .Should().BeTrue();

            this.yamlBrokerMock.Verify(broker =>
                broker.SerializeToYaml(It.IsAny<object>()),
                    Times.Once);

            this.outputBrokerMock.Verify(broker =>
                broker.GenerateFileOutput(It.IsAny<string>(), It.IsAny<string>()),
                    Times.Never);

            this.yamlBrokerMock.VerifyNoOtherCalls();
            this.outputBrokerMock.VerifyNoOtherCalls();
        }
    }
}
