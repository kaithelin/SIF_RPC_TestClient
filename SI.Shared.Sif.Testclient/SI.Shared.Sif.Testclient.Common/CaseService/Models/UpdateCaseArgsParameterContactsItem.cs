﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SI.Shared.Sif.Testclient.Common.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class UpdateCaseArgsParameterContactsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateCaseArgsParameterContactsItem class.
        /// </summary>
        public UpdateCaseArgsParameterContactsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateCaseArgsParameterContactsItem class.
        /// </summary>
        public UpdateCaseArgsParameterContactsItem(string role = default(string), string externalId = default(string), string referenceNumber = default(string), bool? isUnofficial = default(bool?), string contactId = default(string))
        {
            Role = role;
            ExternalId = externalId;
            ReferenceNumber = referenceNumber;
            IsUnofficial = isUnofficial;
            ContactId = contactId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role")]
        public string Role { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceNumber")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsUnofficial")]
        public bool? IsUnofficial { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactId")]
        public string ContactId { get; set; }

    }
}
