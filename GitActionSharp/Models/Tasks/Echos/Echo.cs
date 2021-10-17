// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using YamlDotNet.Serialization;

namespace GitActionSharp.Models.Tasks.Echos
{
    public class Echo : GitActionTask
    {
        [YamlMember(Order = 1)]
        public string Run { get; set; }
    }
}
