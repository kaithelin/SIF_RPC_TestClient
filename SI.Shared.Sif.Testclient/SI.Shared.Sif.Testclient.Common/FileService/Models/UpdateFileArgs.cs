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

    public partial class UpdateFileArgs
    {
        /// <summary>
        /// Initializes a new instance of the UpdateFileArgs class.
        /// </summary>
        public UpdateFileArgs() { }

        /// <summary>
        /// Initializes a new instance of the UpdateFileArgs class.
        /// </summary>
        public UpdateFileArgs(UpdateFileArgsParameter parameter = default(UpdateFileArgsParameter))
        {
            Parameter = parameter;
        }

        /// <summary>
        /// UpdateFileParameter parameter containing Recno of file
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public UpdateFileArgsParameter Parameter { get; set; }

    }
}
