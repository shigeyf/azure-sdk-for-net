// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Billing.Models
{
    using Azure;
    using Management;
    using Billing;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An invoice resource can be used download a PDF version of an invoice.
    /// </summary>
    [JsonTransformation]
    public partial class Invoice : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Invoice class.
        /// </summary>
        public Invoice() { }

        /// <summary>
        /// Initializes a new instance of the Invoice class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="invoicePeriodStartDate">The start of the date range
        /// covered by the invoice.</param>
        /// <param name="invoicePeriodEndDate">The end of the date range
        /// covered by the invoice.</param>
        /// <param name="downloadUrl">A secure link to download the PDF version
        /// of an invoice. The link will cease to work after its expiry time is
        /// reached.</param>
        public Invoice(string id = default(string), string name = default(string), string type = default(string), System.DateTime? invoicePeriodStartDate = default(System.DateTime?), System.DateTime? invoicePeriodEndDate = default(System.DateTime?), DownloadUrl downloadUrl = default(DownloadUrl))
            : base(id, name, type)
        {
            InvoicePeriodStartDate = invoicePeriodStartDate;
            InvoicePeriodEndDate = invoicePeriodEndDate;
            DownloadUrl = downloadUrl;
        }

        /// <summary>
        /// Gets the start of the date range covered by the invoice.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "properties.invoicePeriodStartDate")]
        public System.DateTime? InvoicePeriodStartDate { get; protected set; }

        /// <summary>
        /// Gets the end of the date range covered by the invoice.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "properties.invoicePeriodEndDate")]
        public System.DateTime? InvoicePeriodEndDate { get; protected set; }

        /// <summary>
        /// Gets or sets a secure link to download the PDF version of an
        /// invoice. The link will cease to work after its expiry time is
        /// reached.
        /// </summary>
        [JsonProperty(PropertyName = "properties.downloadUrl")]
        public DownloadUrl DownloadUrl { get; set; }

    }
}
