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

    public partial class CreateProjectArgs
    {
        /// <summary>
        /// Initializes a new instance of the CreateProjectArgs class.
        /// </summary>
        public CreateProjectArgs() { }

        /// <summary>
        /// Initializes a new instance of the CreateProjectArgs class.
        /// </summary>
        public CreateProjectArgs(CreateProjectArgsParameter parameter = default(CreateProjectArgsParameter))
        {
            Parameter = parameter;
        }

        /// <summary>
        /// CreateProjectParameter
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public CreateProjectArgsParameter Parameter { get; set; }

    }
}
