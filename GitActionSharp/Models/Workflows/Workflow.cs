// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using GitActionSharp.Models.Jobs;

namespace GitActionSharp.Models.Workflows
{
    public class Workflow
    {
        public string Name { get; set; }
        public string On { get; set; }
        public Job Jobs { get; set; }
    }
}
