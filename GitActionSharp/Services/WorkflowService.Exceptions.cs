// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

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
        }
    }
}
