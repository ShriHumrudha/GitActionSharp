﻿// ---------------------------------------------------------------
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
                throw new WorkflowDependencyValidationException(argumentNullException);
            }
            catch (ArgumentException argumentException)
            {
                throw new WorkflowDependencyValidationException(argumentException);
            }
            catch (PathTooLongException pathTooLongException)
            {
                throw new WorkflowDependencyValidationException(pathTooLongException);
            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {
                throw new WorkflowDependencyValidationException(directoryNotFoundException);
            }
            catch (IOException ioException)
            {
                throw new WorkflowDependencyException(ioException);
            }
            catch (SecurityException securityException)
            {
                throw new WorkflowDependencyException(securityException);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                throw new WorkflowDependencyException(unauthorizedAccessException);
            }
            catch (NotSupportedException notSupportedException)
            {
                throw new WorkflowDependencyException(notSupportedException);
            }
            catch (Exception exception)
            {
                throw new WorkflowServiceException(exception);
            }
        }
    }
}
