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

    public partial class GetFileOKResponseVersion
    {
        /// <summary>
        /// Initializes a new instance of the GetFileOKResponseVersion class.
        /// </summary>
        public GetFileOKResponseVersion() { }

        /// <summary>
        /// Initializes a new instance of the GetFileOKResponseVersion class.
        /// </summary>
        public GetFileOKResponseVersion(int? major = default(int?), int? minor = default(int?), int? build = default(int?), int? revision = default(int?), object majorRevision = default(object), object minorRevision = default(object))
        {
            Major = major;
            Minor = minor;
            Build = build;
            Revision = revision;
            MajorRevision = majorRevision;
            MinorRevision = minorRevision;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Major")]
        public int? Major { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Minor")]
        public int? Minor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Build")]
        public int? Build { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MajorRevision")]
        public object MajorRevision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinorRevision")]
        public object MinorRevision { get; set; }

    }
}
