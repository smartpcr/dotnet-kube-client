using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference, or a value for non-objects such as user and group names.
    /// </summary>
    public partial class SubjectV1Beta1 : Models.SubjectV1Beta1
    {
        /// <summary>
        ///     Kind of object being referenced. Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.
        /// </summary>
        [JsonProperty("kind")]
        [YamlMember(Alias = "kind")]
        public override string Kind
        {
            get
            {
                return base.Kind;
            }
            set
            {
                base.Kind = value;

                __ModifiedProperties__.Add("Kind");
            }
        }


        /// <summary>
        ///     Name of the object being referenced.
        /// </summary>
        [JsonProperty("name")]
        [YamlMember(Alias = "name")]
        public override string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Name = value;

                __ModifiedProperties__.Add("Name");
            }
        }


        /// <summary>
        ///     Namespace of the referenced object.  If the object kind is non-namespace, such as "User" or "Group", and this value is not empty the Authorizer should report an error.
        /// </summary>
        [JsonProperty("namespace")]
        [YamlMember(Alias = "namespace")]
        public override string Namespace
        {
            get
            {
                return base.Namespace;
            }
            set
            {
                base.Namespace = value;

                __ModifiedProperties__.Add("Namespace");
            }
        }


        /// <summary>
        ///     APIGroup holds the API group of the referenced subject. Defaults to "" for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io" for User and Group subjects.
        /// </summary>
        [JsonProperty("apiGroup")]
        [YamlMember(Alias = "apiGroup")]
        public override string ApiGroup
        {
            get
            {
                return base.ApiGroup;
            }
            set
            {
                base.ApiGroup = value;

                __ModifiedProperties__.Add("ApiGroup");
            }
        }


        /// <summary>
        ///     Names of model properties that have been modified.
        /// </summary>
        [JsonIgnore, YamlIgnore]
        public HashSet<string> __ModifiedProperties__ { get; } = new HashSet<string>();
    }
}