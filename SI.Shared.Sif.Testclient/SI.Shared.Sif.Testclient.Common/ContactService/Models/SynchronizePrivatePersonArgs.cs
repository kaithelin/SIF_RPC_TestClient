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

    public partial class SynchronizePrivatePersonArgs
    {
        /// <summary>
        /// Initializes a new instance of the SynchronizePrivatePersonArgs
        /// class.
        /// </summary>
        public SynchronizePrivatePersonArgs() { }

        /// <summary>
        /// Initializes a new instance of the SynchronizePrivatePersonArgs
        /// class.
        /// </summary>
        public SynchronizePrivatePersonArgs(SynchronizePrivatePersonArgsParameter parameter = default(SynchronizePrivatePersonArgsParameter))
        {
            Parameter = parameter;
        }

        /// <summary>
        /// SynchronizePrivatePersonParameter.
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public SynchronizePrivatePersonArgsParameter Parameter { get; set; }

    }
}
