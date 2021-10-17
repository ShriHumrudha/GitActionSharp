// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization.TypeInspectors;

namespace GitActionSharp.Brokers.Serializers
{
    public class YamlBroker : IYamlBroker
    {
        private readonly ISerializer serializer;

        public YamlBroker()
        {
            this.serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .WithTypeInspector(inner => inner,
                        s => s.InsteadOf<YamlAttributesTypeInspector>())
                            .WithTypeInspector(inner => new YamlAttributesTypeInspector(inner),
                                s => s.Before<NamingConventionTypeInspector>())
                                    .Build();
        }

        public string SerializeToYaml(object @object) =>
            this.serializer.Serialize(@object);
    }
}
