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

    public partial class GetFileOKResponseContentHeadersItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetFileOKResponseContentHeadersItem class.
        /// </summary>
        public GetFileOKResponseContentHeadersItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// GetFileOKResponseContentHeadersItem class.
        /// </summary>
        public GetFileOKResponseContentHeadersItem(string key = default(string), IList<string> value = default(IList<string>))
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public IList<string> Value { get; set; }

    }
}
