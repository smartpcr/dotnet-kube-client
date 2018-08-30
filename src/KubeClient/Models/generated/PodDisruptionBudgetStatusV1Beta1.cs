using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PodDisruptionBudgetStatus represents information about the status of a PodDisruptionBudget. Status may trail the actual state of a system.
    /// </summary>
    public partial class PodDisruptionBudgetStatusV1Beta1
    {
        /// <summary>
        ///     Number of pod disruptions that are currently allowed.
        /// </summary>
        [JsonProperty("disruptionsAllowed")]
        [YamlMember(Alias = "disruptionsAllowed")]
        public virtual int DisruptionsAllowed { get; set; }

        /// <summary>
        ///     Most recent generation observed when updating this PDB status. PodDisruptionsAllowed and other status informatio is valid only if observedGeneration equals to PDB's object generation.
        /// </summary>
        [JsonProperty("observedGeneration")]
        [YamlMember(Alias = "observedGeneration")]
        public virtual int ObservedGeneration { get; set; }

        /// <summary>
        ///     DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.
        /// </summary>
        [YamlMember(Alias = "disruptedPods")]
        [JsonProperty("disruptedPods", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Dictionary<string, DateTime> DisruptedPods { get; set; } = new Dictionary<string, DateTime>();

        /// <summary>
        ///     total number of pods counted by this disruption budget
        /// </summary>
        [JsonProperty("expectedPods")]
        [YamlMember(Alias = "expectedPods")]
        public virtual int ExpectedPods { get; set; }

        /// <summary>
        ///     current number of healthy pods
        /// </summary>
        [JsonProperty("currentHealthy")]
        [YamlMember(Alias = "currentHealthy")]
        public virtual int CurrentHealthy { get; set; }

        /// <summary>
        ///     minimum desired number of healthy pods
        /// </summary>
        [JsonProperty("desiredHealthy")]
        [YamlMember(Alias = "desiredHealthy")]
        public virtual int DesiredHealthy { get; set; }
    }
}
