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

    public partial class CreateProjectArgsParameterExternalId
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateProjectArgsParameterExternalId class.
        /// </summary>
        public CreateProjectArgsParameterExternalId() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateProjectArgsParameterExternalId class.
        /// </summary>
        public CreateProjectArgsParameterExternalId(string id = default(string), string type = default(string))
        {
            Id = id;
            Type = type;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

    }
}
