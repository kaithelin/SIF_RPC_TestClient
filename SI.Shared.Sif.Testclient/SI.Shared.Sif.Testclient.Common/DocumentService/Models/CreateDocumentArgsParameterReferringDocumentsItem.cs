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

    public partial class CreateDocumentArgsParameterReferringDocumentsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateDocumentArgsParameterReferringDocumentsItem class.
        /// </summary>
        public CreateDocumentArgsParameterReferringDocumentsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateDocumentArgsParameterReferringDocumentsItem class.
        /// </summary>
        public CreateDocumentArgsParameterReferringDocumentsItem(string documentNumber = default(string))
        {
            DocumentNumber = documentNumber;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentNumber")]
        public string DocumentNumber { get; set; }

    }
}
