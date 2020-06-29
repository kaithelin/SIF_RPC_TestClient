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

    public partial class GetCasesOKResponseCasesItem
    {
        /// <summary>
        /// Initializes a new instance of the GetCasesOKResponseCasesItem
        /// class.
        /// </summary>
        public GetCasesOKResponseCasesItem() { }

        /// <summary>
        /// Initializes a new instance of the GetCasesOKResponseCasesItem
        /// class.
        /// </summary>
        public GetCasesOKResponseCasesItem(int? recno = default(int?), string caseNumber = default(string), GetCasesOKResponseCasesItemExternalId externalId = default(GetCasesOKResponseCasesItemExternalId), string title = default(string), DateTime? date = default(DateTime?), string status = default(string), string accessCodeDescription = default(string), string accessCodeCode = default(string), string accessGroup = default(string), string paragraph = default(string), GetCasesOKResponseCasesItemResponsibleEnterprise responsibleEnterprise = default(GetCasesOKResponseCasesItemResponsibleEnterprise), string responsibleEnterpriseName = default(string), GetCasesOKResponseCasesItemResponsiblePerson responsiblePerson = default(GetCasesOKResponseCasesItemResponsiblePerson), string responsiblePersonName = default(string), object archiveCodes = default(object), object documents = default(object), object referringCases = default(object), object referringDocuments = default(object), string unofficialTitle = default(string), DateTime? createdDate = default(DateTime?), string notes = default(string), string caseTypeCode = default(string), string caseTypeDescription = default(string), object contacts = default(object), string projectRecno = default(string), string projectName = default(string), string subArchive = default(string), string subArchiveCode = default(string), object caseEstates = default(object), string caseRowPermissions = default(string), object customFields = default(object), DateTime? lastChangedDate = default(DateTime?), GetCasesOKResponseCasesItemProgressPlan progressPlan = default(GetCasesOKResponseCasesItemProgressPlan), string subjectSpecificMetaData = default(string), string subjectSpecificMetaDataNamespace = default(string), string uRL = default(string))
        {
            Recno = recno;
            CaseNumber = caseNumber;
            ExternalId = externalId;
            Title = title;
            Date = date;
            Status = status;
            AccessCodeDescription = accessCodeDescription;
            AccessCodeCode = accessCodeCode;
            AccessGroup = accessGroup;
            Paragraph = paragraph;
            ResponsibleEnterprise = responsibleEnterprise;
            ResponsibleEnterpriseName = responsibleEnterpriseName;
            ResponsiblePerson = responsiblePerson;
            ResponsiblePersonName = responsiblePersonName;
            ArchiveCodes = archiveCodes;
            Documents = documents;
            ReferringCases = referringCases;
            ReferringDocuments = referringDocuments;
            UnofficialTitle = unofficialTitle;
            CreatedDate = createdDate;
            Notes = notes;
            CaseTypeCode = caseTypeCode;
            CaseTypeDescription = caseTypeDescription;
            Contacts = contacts;
            ProjectRecno = projectRecno;
            ProjectName = projectName;
            SubArchive = subArchive;
            SubArchiveCode = subArchiveCode;
            CaseEstates = caseEstates;
            CaseRowPermissions = caseRowPermissions;
            CustomFields = customFields;
            LastChangedDate = lastChangedDate;
            ProgressPlan = progressPlan;
            SubjectSpecificMetaData = subjectSpecificMetaData;
            SubjectSpecificMetaDataNamespace = subjectSpecificMetaDataNamespace;
            URL = uRL;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Recno")]
        public int? Recno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseNumber")]
        public string CaseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalId")]
        public GetCasesOKResponseCasesItemExternalId ExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessCodeDescription")]
        public string AccessCodeDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessCodeCode")]
        public string AccessCodeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessGroup")]
        public string AccessGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Paragraph")]
        public string Paragraph { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsibleEnterprise")]
        public GetCasesOKResponseCasesItemResponsibleEnterprise ResponsibleEnterprise { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsibleEnterpriseName")]
        public string ResponsibleEnterpriseName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePerson")]
        public GetCasesOKResponseCasesItemResponsiblePerson ResponsiblePerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonName")]
        public string ResponsiblePersonName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ArchiveCodes")]
        public object ArchiveCodes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Documents")]
        public object Documents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferringCases")]
        public object ReferringCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferringDocuments")]
        public object ReferringDocuments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UnofficialTitle")]
        public string UnofficialTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Notes")]
        public string Notes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseTypeCode")]
        public string CaseTypeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseTypeDescription")]
        public string CaseTypeDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contacts")]
        public object Contacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProjectRecno")]
        public string ProjectRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProjectName")]
        public string ProjectName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubArchive")]
        public string SubArchive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubArchiveCode")]
        public string SubArchiveCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseEstates")]
        public object CaseEstates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseRowPermissions")]
        public string CaseRowPermissions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomFields")]
        public object CustomFields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastChangedDate")]
        public DateTime? LastChangedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProgressPlan")]
        public GetCasesOKResponseCasesItemProgressPlan ProgressPlan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectSpecificMetaData")]
        public string SubjectSpecificMetaData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectSpecificMetaDataNamespace")]
        public string SubjectSpecificMetaDataNamespace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "URL")]
        public string URL { get; set; }

    }
}
