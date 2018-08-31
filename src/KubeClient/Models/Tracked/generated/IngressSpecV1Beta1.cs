using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     IngressSpec describes the Ingress the user wishes to exist.
    /// </summary>
    public partial class IngressSpecV1Beta1 : Models.IngressSpecV1Beta1
    {
        /// <summary>
        ///     A default backend capable of servicing requests that don't match any rule. At least one of 'backend' or 'rules' must be specified. This field is optional to allow the loadbalancer controller or defaulting logic to specify a global default.
        /// </summary>
        [JsonProperty("backend")]
        [YamlMember(Alias = "backend")]
        public override Models.IngressBackendV1Beta1 Backend
        {
            get
            {
                return base.Backend;
            }
            set
            {
                base.Backend = value;

                __ModifiedProperties__.Add("Backend");
            }
        }


        /// <summary>
        ///     A list of host rules used to configure the Ingress. If unspecified, or no rule matches, all traffic is sent to the default backend.
        /// </summary>
        [YamlMember(Alias = "rules")]
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public override List<Models.IngressRuleV1Beta1> Rules { get; set; } = new List<Models.IngressRuleV1Beta1>();

        /// <summary>
        ///     TLS configuration. Currently the Ingress only supports a single TLS port, 443. If multiple members of this list specify different hosts, they will be multiplexed on the same port according to the hostname specified through the SNI TLS extension, if the ingress controller fulfilling the ingress supports SNI.
        /// </summary>
        [YamlMember(Alias = "tls")]
        [JsonProperty("tls", NullValueHandling = NullValueHandling.Ignore)]
        public override List<Models.IngressTLSV1Beta1> Tls { get; set; } = new List<Models.IngressTLSV1Beta1>();

        /// <summary>
        ///     Names of model properties that have been modified.
        /// </summary>
        [JsonIgnore, YamlIgnore]
        public HashSet<string> __ModifiedProperties__ { get; } = new HashSet<string>();
    }
}