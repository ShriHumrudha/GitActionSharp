// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

namespace GitActionSharp.Brokers.Serializers
{
    public interface IYamlBroker
    {
        string SerializeToYaml(object @object);
    }
}
