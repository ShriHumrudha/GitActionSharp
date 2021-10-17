// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using YamlDotNet.Serialization;

namespace GitActionSharp.Models.Tasks
{
    public class GitActionTask
    {
        [YamlMember(Order = 0)]
        public string Name { get; set; }
    }
}
