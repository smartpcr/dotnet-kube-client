using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     StatefulSetList is a collection of StatefulSets.
    /// </summary>
    [KubeListItem("StatefulSet", "apps/v1beta1")]
    [KubeObject("StatefulSetList", "apps/v1beta1")]
    public partial class StatefulSetListV1Beta1 : Models.StatefulSetListV1Beta1
    {
        /// <summary>
        ///     Description not provided.
        /// </summary>
        [JsonProperty("items", ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        public override List<Models.StatefulSetV1Beta1> Items { get; } = new List<Models.StatefulSetV1Beta1>();
    }
}