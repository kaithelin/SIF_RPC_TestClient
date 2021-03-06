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

    public partial class GetCodeTableRowsOKResponseCodeTableRowsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetCodeTableRowsOKResponseCodeTableRowsItem class.
        /// </summary>
        public GetCodeTableRowsOKResponseCodeTableRowsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// GetCodeTableRowsOKResponseCodeTableRowsItem class.
        /// </summary>
        public GetCodeTableRowsOKResponseCodeTableRowsItem(string language = default(string), bool? isExpired = default(bool?), int? recno = default(int?), string code = default(string), string description = default(string))
        {
            Language = language;
            IsExpired = isExpired;
            Recno = recno;
            Code = code;
            Description = description;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Language")]
        public string Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsExpired")]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Recno")]
        public int? Recno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

    }
}
