using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     DeploymentRollback stores the information required to rollback a deployment.
    /// </summary>
    public partial class DeploymentRollbackV1Beta1
    {
        /// <summary>
        ///     Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty("kind")]
        [YamlMember(Alias = "kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        ///     Required: This must match the Name of a deployment.
        /// </summary>
        [JsonProperty("name")]
        [YamlMember(Alias = "name")]
        public virtual string Name { get; set; }

        /// <summary>
        ///     APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty("apiVersion")]
        [YamlMember(Alias = "apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        ///     The config of this deployment rollback.
        /// </summary>
        [JsonProperty("rollbackTo")]
        [YamlMember(Alias = "rollbackTo")]
        public virtual RollbackConfigV1Beta1 RollbackTo { get; set; }

        /// <summary>
        ///     The annotations to be updated to a deployment
        /// </summary>
        [YamlMember(Alias = "updatedAnnotations")]
        [JsonProperty("updatedAnnotations", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Dictionary<string, string> UpdatedAnnotations { get; set; } = new Dictionary<string, string>();
    }
}
