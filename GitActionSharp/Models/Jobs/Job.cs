// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System.Collections.Generic;
using GitActionSharp.Models.Tasks;
using YamlDotNet.Serialization;

namespace GitActionSharp.Models.Jobs
{
    public class Job
    {
        [YamlMember(Alias = "runs-on")]
        public string RunsOn { get; set; }

        public List<GitActionTask> Steps { get; set; }
    }
}
