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
    /// DispatchDocumentsParameter
    /// </summary>
    public partial class DispatchDocumentsArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the DispatchDocumentsArgsParameter
        /// class.
        /// </summary>
        public DispatchDocumentsArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the DispatchDocumentsArgsParameter
        /// class.
        /// </summary>
        public DispatchDocumentsArgsParameter(string aDContextUser = default(string), IList<DispatchDocumentsArgsParameterDocumentsItem> documents = default(IList<DispatchDocumentsArgsParameterDocumentsItem>))
        {
            ADContextUser = aDContextUser;
            Documents = documents;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ADContextUser")]
        public string ADContextUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Documents")]
        public IList<DispatchDocumentsArgsParameterDocumentsItem> Documents { get; set; }

    }
}
