// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;
using System.IO;
using System.Security;
using GitActionSharp.Models.Workflows.Exceptions;

namespace GitActionSharp.Services
{
    public partial class WorkflowService
    {
        private delegate void ReturningNothingFunction();

        private static void TryCatch(ReturningNothingFunction returningNothingFunction)
        {
            try
            {
                returningNothingFunction();
            }
            catch (NullPathException nullPathException)
            {
                throw new WorkflowValidationException(nullPathException);
            }
            catch (NullWorfklowException nullWorfklowException)
            {
                throw new WorkflowValidationException(nullWorfklowException);
            }
            catch (ArgumentNullException argumentNullException)
            {
                var failedWorkflowDependencyValidationException =
                    new FailedWorkflowDependencyValidationException(
                        argumentNullException);

                throw new WorkflowDependencyValidationException(
                    failedWorkflowDependencyValidationException);
            }
            catch (ArgumentException argumentException)
            {
                var failedWorkflowDependencyValidationException =
                   new FailedWorkflowDependencyValidationException(
                       argumentException);

                throw new WorkflowDependencyValidationException(
                    failedWorkflowDependencyValidationException);
            }
            catch (PathTooLongException pathTooLongException)
            {
                var failedWorkflowDependencyValidationException =
                   new FailedWorkflowDependencyValidationException(
                       pathTooLongException);

                throw new WorkflowDependencyValidationException(
                    failedWorkflowDependencyValidationException);
            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {
                var failedWorkflowDependencyValidationException =
                   new FailedWorkflowDependencyValidationException(
                       directoryNotFoundException);

                throw new WorkflowDependencyValidationException(
                    failedWorkflowDependencyValidationException);
            }
            catch (IOException ioException)
            {
                var failedWorkflowDependencyException =
                   new FailedWorkflowDependencyException(
                       ioException);

                throw new WorkflowDependencyException(
                    failedWorkflowDependencyException);
            }
            catch (SecurityException securityException)
            {
                var failedWorkflowDependencyException =
                   new FailedWorkflowDependencyException(
                       securityException);

                throw new WorkflowDependencyException(
                    failedWorkflowDependencyException);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                var failedWorkflowDependencyException =
                   new FailedWorkflowDependencyException(
                       unauthorizedAccessException);

                throw new WorkflowDependencyException(
                    failedWorkflowDependencyException);
            }
            catch (NotSupportedException notSupportedException)
            {
                var failedWorkflowDependencyException =
                   new FailedWorkflowDependencyException(
                       notSupportedException);

                throw new WorkflowDependencyException(
                    failedWorkflowDependencyException);
            }
            catch (Exception exception)
            {
                var failedWorkflowSericeException =
                    new FailedWorkflowServiceException(exception);

                throw new WorkflowServiceException(
                    failedWorkflowSericeException);
            }
        }
    }
}
