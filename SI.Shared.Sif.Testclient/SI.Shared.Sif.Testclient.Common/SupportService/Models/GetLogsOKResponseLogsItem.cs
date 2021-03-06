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

    public partial class GetLogsOKResponseLogsItem
    {
        /// <summary>
        /// Initializes a new instance of the GetLogsOKResponseLogsItem class.
        /// </summary>
        public GetLogsOKResponseLogsItem() { }

        /// <summary>
        /// Initializes a new instance of the GetLogsOKResponseLogsItem class.
        /// </summary>
        public GetLogsOKResponseLogsItem(int? recno = default(int?), string entityName = default(string), string entityRecno = default(string), string infoTypeCode = default(string), string infoTypeDescription = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), string data = default(string), string dataFrom = default(string), string dataTo = default(string))
        {
            Recno = recno;
            EntityName = entityName;
            EntityRecno = entityRecno;
            InfoTypeCode = infoTypeCode;
            InfoTypeDescription = infoTypeDescription;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
            Data = data;
            DataFrom = dataFrom;
            DataTo = dataTo;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Recno")]
        public int? Recno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityRecno")]
        public string EntityRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InfoTypeCode")]
        public string InfoTypeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InfoTypeDescription")]
        public string InfoTypeDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Data")]
        public string Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataFrom")]
        public string DataFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataTo")]
        public string DataTo { get; set; }

    }
}
