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

    public partial class DispatchDocumentsArgs
    {
        /// <summary>
        /// Initializes a new instance of the DispatchDocumentsArgs class.
        /// </summary>
        public DispatchDocumentsArgs() { }

        /// <summary>
        /// Initializes a new instance of the DispatchDocumentsArgs class.
        /// </summary>
        public DispatchDocumentsArgs(DispatchDocumentsArgsParameter parameter = default(DispatchDocumentsArgsParameter))
        {
            Parameter = parameter;
        }

        /// <summary>
        /// DispatchDocumentsParameter
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public DispatchDocumentsArgsParameter Parameter { get; set; }

    }
}
