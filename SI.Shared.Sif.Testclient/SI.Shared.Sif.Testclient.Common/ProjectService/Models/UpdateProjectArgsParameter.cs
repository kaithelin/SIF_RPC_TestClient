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
    /// UpdateProjectParameter
    /// </summary>
    public partial class UpdateProjectArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the UpdateProjectArgsParameter class.
        /// </summary>
        public UpdateProjectArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the UpdateProjectArgsParameter class.
        /// </summary>
        public UpdateProjectArgsParameter(string projectNumber = default(string), bool? syncProjectContacts = default(bool?), string aDContextUser = default(string), UpdateProjectArgsParameterExternalId externalId = default(UpdateProjectArgsParameterExternalId), string title = default(string), string category = default(string), string status = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string accessGroup = default(string), string notes = default(string), int? responsiblePersonRecno = default(int?), string responsiblePersonIdNumber = default(string), string responsiblePersonEmail = default(string), string responsiblePersonUserId = default(string), IList<UpdateProjectArgsParameterAdditionalFieldsItem> additionalFields = default(IList<UpdateProjectArgsParameterAdditionalFieldsItem>), IList<UpdateProjectArgsParameterEstatesItem> estates = default(IList<UpdateProjectArgsParameterEstatesItem>), IList<UpdateProjectArgsParameterContactsItem> contacts = default(IList<UpdateProjectArgsParameterContactsItem>))
        {
            ProjectNumber = projectNumber;
            SyncProjectContacts = syncProjectContacts;
            ADContextUser = aDContextUser;
            ExternalId = externalId;
            Title = title;
            Category = category;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
            AccessGroup = accessGroup;
            Notes = notes;
            ResponsiblePersonRecno = responsiblePersonRecno;
            ResponsiblePersonIdNumber = responsiblePersonIdNumber;
            ResponsiblePersonEmail = responsiblePersonEmail;
            ResponsiblePersonUserId = responsiblePersonUserId;
            AdditionalFields = additionalFields;
            Estates = estates;
            Contacts = contacts;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProjectNumber")]
        public string ProjectNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SyncProjectContacts")]
        public bool? SyncProjectContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ADContextUser")]
        public string ADContextUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalId")]
        public UpdateProjectArgsParameterExternalId ExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessGroup")]
        public string AccessGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Notes")]
        public string Notes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonRecno")]
        public int? ResponsiblePersonRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonIdNumber")]
        public string ResponsiblePersonIdNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonEmail")]
        public string ResponsiblePersonEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonUserId")]
        public string ResponsiblePersonUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdditionalFields")]
        public IList<UpdateProjectArgsParameterAdditionalFieldsItem> AdditionalFields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Estates")]
        public IList<UpdateProjectArgsParameterEstatesItem> Estates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contacts")]
        public IList<UpdateProjectArgsParameterContactsItem> Contacts { get; set; }

    }
}
