// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The NetworkSettings of a device
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkSettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        public NetworkSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        /// <param name="primaryDnsServer">The Primary DNS server for the
        /// device</param>
        /// <param name="nodeNetworks">The NetworkAdapters under each node of
        /// the device.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="secondaryDnsServer">The secondary DNS server for the
        /// device</param>
        public NetworkSettings(string primaryDnsServer, IList<NodeNetwork> nodeNetworks, string id = default(string), string name = default(string), string type = default(string), string secondaryDnsServer = default(string))
            : base(id, name, type)
        {
            PrimaryDnsServer = primaryDnsServer;
            SecondaryDnsServer = secondaryDnsServer;
            NodeNetworks = nodeNetworks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Primary DNS server for the device
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryDnsServer")]
        public string PrimaryDnsServer { get; set; }

        /// <summary>
        /// Gets or sets the secondary DNS server for the device
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryDnsServer")]
        public string SecondaryDnsServer { get; set; }

        /// <summary>
        /// Gets or sets the NetworkAdapters under each node of the device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeNetworks")]
        public IList<NodeNetwork> NodeNetworks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PrimaryDnsServer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrimaryDnsServer");
            }
            if (NodeNetworks == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NodeNetworks");
            }
            if (NodeNetworks != null)
            {
                foreach (var element in NodeNetworks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}