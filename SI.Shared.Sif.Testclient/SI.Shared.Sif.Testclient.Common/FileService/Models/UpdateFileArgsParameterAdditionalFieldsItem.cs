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

    public partial class UpdateFileArgsParameterAdditionalFieldsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateFileArgsParameterAdditionalFieldsItem class.
        /// </summary>
        public UpdateFileArgsParameterAdditionalFieldsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateFileArgsParameterAdditionalFieldsItem class.
        /// </summary>
        public UpdateFileArgsParameterAdditionalFieldsItem(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}
