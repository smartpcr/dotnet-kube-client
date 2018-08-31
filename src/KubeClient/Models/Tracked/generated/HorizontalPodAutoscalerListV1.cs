using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     list of horizontal pod autoscaler objects.
    /// </summary>
    [KubeListItem("HorizontalPodAutoscaler", "autoscaling/v1")]
    [KubeObject("HorizontalPodAutoscalerList", "autoscaling/v1")]
    public partial class HorizontalPodAutoscalerListV1 : Models.HorizontalPodAutoscalerListV1
    {
        /// <summary>
        ///     list of horizontal pod autoscaler objects.
        /// </summary>
        [JsonProperty("items", ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        public override List<Models.HorizontalPodAutoscalerV1> Items { get; } = new List<Models.HorizontalPodAutoscalerV1>();
    }
}