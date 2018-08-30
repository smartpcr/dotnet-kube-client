using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
    /// </summary>
    public partial class TolerationV1
    {
        /// <summary>
        ///     Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.
        /// </summary>
        [JsonProperty("value")]
        [YamlMember(Alias = "value")]
        public virtual string Value { get; set; }

        /// <summary>
        ///     Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.
        /// </summary>
        [JsonProperty("operator")]
        [YamlMember(Alias = "operator")]
        public virtual string Operator { get; set; }

        /// <summary>
        ///     TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.
        /// </summary>
        [JsonProperty("tolerationSeconds")]
        [YamlMember(Alias = "tolerationSeconds")]
        public virtual int TolerationSeconds { get; set; }

        /// <summary>
        ///     Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
        /// </summary>
        [JsonProperty("effect")]
        [YamlMember(Alias = "effect")]
        public virtual string Effect { get; set; }

        /// <summary>
        ///     Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.
        /// </summary>
        [JsonProperty("key")]
        [YamlMember(Alias = "key")]
        [MergeStrategy(Key = "key")]
        public virtual string Key { get; set; }
    }
}
