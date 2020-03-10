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

    /// <summary>
    /// DeleteFileParameter parameter containing Recno of file
    /// </summary>
    public partial class DeleteFileArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the DeleteFileArgsParameter class.
        /// </summary>
        public DeleteFileArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the DeleteFileArgsParameter class.
        /// </summary>
        public DeleteFileArgsParameter(int? fileRecno = default(int?), string aDContextUser = default(string))
        {
            FileRecno = fileRecno;
            ADContextUser = aDContextUser;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileRecno")]
        public int? FileRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ADContextUser")]
        public string ADContextUser { get; set; }

    }
}
