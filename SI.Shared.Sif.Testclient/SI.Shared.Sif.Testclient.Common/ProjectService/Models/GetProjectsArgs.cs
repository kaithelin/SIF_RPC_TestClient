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

    public partial class GetProjectsArgs
    {
        /// <summary>
        /// Initializes a new instance of the GetProjectsArgs class.
        /// </summary>
        public GetProjectsArgs() { }

        /// <summary>
        /// Initializes a new instance of the GetProjectsArgs class.
        /// </summary>
        public GetProjectsArgs(GetProjectsArgsParameter parameter = default(GetProjectsArgsParameter))
        {
            Parameter = parameter;
        }

        /// <summary>
        /// GetProjectsQuery with metadata to get projects
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public GetProjectsArgsParameter Parameter { get; set; }

    }
}
