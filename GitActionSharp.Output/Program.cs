// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System.Collections.Generic;
using GitActionSharp.Client;
using GitActionSharp.Models.Jobs;
using GitActionSharp.Models.Jobs.Machines;
using GitActionSharp.Models.Tasks;
using GitActionSharp.Models.Tasks.Echos;
using GitActionSharp.Models.Workflows;

namespace GitActionSharp.Output
{
    public class Program
    {
        static void Main(string[] args)
        {
            WorkflowClient workflowClient = new WorkflowClient();

            var workflow = new Workflow
            {
                Name = "Hello World!",
                On = "push",

                Jobs = new Job
                {
                    Echo = new EchoJob
                    {
                        RunsOn = Machine.WindowsLatest,

                        Steps = new List<GitActionTask>
                        {
                            new Echo
                            {
                                Name = "Print",
                                Run = "echo My First Git Action using GitActionSharp."
                            }
                        }
                    }
                }
            };

            workflowClient.CreateWorkflow("../../../../.github/workflows/echo.yml", workflow);
        }
    }
}
