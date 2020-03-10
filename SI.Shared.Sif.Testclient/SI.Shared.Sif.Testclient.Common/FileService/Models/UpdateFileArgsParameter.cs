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
    /// UpdateFileParameter parameter containing Recno of file
    /// </summary>
    public partial class UpdateFileArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the UpdateFileArgsParameter class.
        /// </summary>
        public UpdateFileArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the UpdateFileArgsParameter class.
        /// </summary>
        public UpdateFileArgsParameter(int? fileRecno = default(int?), string comment = default(string), string note = default(string), string category = default(string), bool? filedOnPaper = default(bool?), string aDContextUser = default(string), IList<object> data = default(IList<object>), string versionFormat = default(string), string title = default(string), string format = default(string), IList<UpdateFileArgsParameterAdditionalFieldsItem> additionalFields = default(IList<UpdateFileArgsParameterAdditionalFieldsItem>))
        {
            FileRecno = fileRecno;
            Comment = comment;
            Note = note;
            Category = category;
            FiledOnPaper = filedOnPaper;
            ADContextUser = aDContextUser;
            Data = data;
            VersionFormat = versionFormat;
            Title = title;
            Format = format;
            AdditionalFields = additionalFields;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileRecno")]
        public int? FileRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Comment")]
        public string Comment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Note")]
        public string Note { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FiledOnPaper")]
        public bool? FiledOnPaper { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ADContextUser")]
        public string ADContextUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Data")]
        public IList<object> Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VersionFormat")]
        public string VersionFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Format")]
        public string Format { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdditionalFields")]
        public IList<UpdateFileArgsParameterAdditionalFieldsItem> AdditionalFields { get; set; }

    }
}