using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.
    /// </summary>
    public partial class RollingUpdateStatefulSetStrategyV1Beta1
    {
        /// <summary>
        ///     Partition indicates the ordinal at which the StatefulSet should be partitioned.
        /// </summary>
        [JsonProperty("partition")]
        [YamlMember(Alias = "partition")]
        public virtual int Partition { get; set; }
    }
}
