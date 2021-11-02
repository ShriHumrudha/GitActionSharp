// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitActionSharp.Models.Tasks;
using YamlDotNet.Serialization;

namespace GitActionSharp.Models.Jobs
{
    public class EchoJob
    {
        [YamlMember(Alias = "runs-on")]
        public string RunsOn { get; set; }

        public List<GitActionTask> Steps { get; set; }
    }
}
