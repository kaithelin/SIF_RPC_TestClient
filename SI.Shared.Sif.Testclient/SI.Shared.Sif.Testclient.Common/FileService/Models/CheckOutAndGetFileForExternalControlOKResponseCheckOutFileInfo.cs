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

    public partial class CheckOutAndGetFileForExternalControlOKResponseCheckOutFileInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckOutAndGetFileForExternalControlOKResponseCheckOutFileInfo
        /// class.
        /// </summary>
        public CheckOutAndGetFileForExternalControlOKResponseCheckOutFileInfo() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckOutAndGetFileForExternalControlOKResponseCheckOutFileInfo
        /// class.
        /// </summary>
        public CheckOutAndGetFileForExternalControlOKResponseCheckOutFileInfo(bool? successful = default(bool?), string errorMessage = default(string), string errorDetails = default(string), string title = default(string), string templateId = default(string), string fileRecno = default(string))
        {
            Successful = successful;
            ErrorMessage = errorMessage;
            ErrorDetails = errorDetails;
            Title = title;
            TemplateId = templateId;
            FileRecno = fileRecno;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorDetails")]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TemplateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileRecno")]
        public string FileRecno { get; set; }

    }
}