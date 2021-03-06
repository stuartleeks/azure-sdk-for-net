// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Pool of backend IP addresses
    /// </summary>
    [JsonTransformation]
    public partial class BackendAddressPool : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the BackendAddressPool class.
        /// </summary>
        public BackendAddressPool() { }

        /// <summary>
        /// Initializes a new instance of the BackendAddressPool class.
        /// </summary>
        public BackendAddressPool(string id = default(string), IList<NetworkInterfaceIPConfiguration> backendIPConfigurations = default(IList<NetworkInterfaceIPConfiguration>), IList<SubResource> loadBalancingRules = default(IList<SubResource>), SubResource outboundNatRule = default(SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            BackendIPConfigurations = backendIPConfigurations;
            LoadBalancingRules = loadBalancingRules;
            OutboundNatRule = outboundNatRule;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets collection of references to IPs defined in NICs
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendIPConfigurations")]
        public IList<NetworkInterfaceIPConfiguration> BackendIPConfigurations { get; private set; }

        /// <summary>
        /// Gets Load Balancing rules that use this Backend Address Pool
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<SubResource> LoadBalancingRules { get; private set; }

        /// <summary>
        /// Gets outbound rules that use this Backend Address Pool
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundNatRule")]
        public SubResource OutboundNatRule { get; private set; }

        /// <summary>
        /// Get provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
