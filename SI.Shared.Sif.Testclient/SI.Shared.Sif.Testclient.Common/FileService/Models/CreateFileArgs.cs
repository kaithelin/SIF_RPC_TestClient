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

    public partial class CreateFileArgs
    {
        /// <summary>
        /// Initializes a new instance of the CreateFileArgs class.
        /// </summary>
        public CreateFileArgs() { }

        /// <summary>
        /// Initializes a new instance of the CreateFileArgs class.
        /// </summary>
        public CreateFileArgs(CreateFileArgsParameter parameter = default(CreateFileArgsParameter))
        {
            Parameter = parameter;
        }

        /// <summary>
        /// FileParameterBase parameter containing Document and ADContextUser
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public CreateFileArgsParameter Parameter { get; set; }

    }
}
