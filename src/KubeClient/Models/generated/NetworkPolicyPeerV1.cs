using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     NetworkPolicyPeer describes a peer to allow traffic from. Exactly one of its fields must be specified.
    /// </summary>
    public partial class NetworkPolicyPeerV1
    {
        /// <summary>
        ///     Selects Namespaces using cluster scoped-labels. This matches all pods in all namespaces selected by this label selector. This field follows standard label selector semantics. If present but empty, this selector selects all namespaces.
        /// </summary>
        [JsonProperty("namespaceSelector")]
        [YamlMember(Alias = "namespaceSelector")]
        public LabelSelectorV1 NamespaceSelector { get; set; }

        /// <summary>
        ///     This is a label selector which selects Pods in this namespace. This field follows standard label selector semantics. If present but empty, this selector selects all pods in this namespace.
        /// </summary>
        [JsonProperty("podSelector")]
        [YamlMember(Alias = "podSelector")]
        public LabelSelectorV1 PodSelector { get; set; }
    }
}
