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
    /// UpdateDocumentParameter with metadata to update document
    /// </summary>
    public partial class UpdateDocumentArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDocumentArgsParameter
        /// class.
        /// </summary>
        public UpdateDocumentArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the UpdateDocumentArgsParameter
        /// class.
        /// </summary>
        public UpdateDocumentArgsParameter(string documentNumber = default(string), bool? syncDocumentContacts = default(bool?), string aDContextUser = default(string), string title = default(string), string unofficialTitle = default(string), DateTime? documentDate = default(DateTime?), string category = default(string), string status = default(string), string accessCode = default(string), string accessGroup = default(string), int? responsiblePersonRecno = default(int?), string responsiblePersonIdNumber = default(string), string responsiblePersonEmail = default(string), string responsiblePersonUserId = default(string), int? responsibleEnterpriseRecno = default(int?), string responsibleEnterpriseNumber = default(string), IList<UpdateDocumentArgsParameterContactsItem> contacts = default(IList<UpdateDocumentArgsParameterContactsItem>), IList<UpdateDocumentArgsParameterUnregisteredContactsItem> unregisteredContacts = default(IList<UpdateDocumentArgsParameterUnregisteredContactsItem>), string sendersReference = default(string), string paragraph = default(string), DateTime? journalDate = default(DateTime?), DateTime? dispatchedDate = default(DateTime?), bool? filedOnPaper = default(bool?), string notes = default(string), IList<UpdateDocumentArgsParameterReferringCasesItem> referringCases = default(IList<UpdateDocumentArgsParameterReferringCasesItem>), IList<UpdateDocumentArgsParameterReferringDocumentsItem> referringDocuments = default(IList<UpdateDocumentArgsParameterReferringDocumentsItem>), IList<string> keywords = default(IList<string>), IList<UpdateDocumentArgsParameterFilesFromTemplateItem> filesFromTemplate = default(IList<UpdateDocumentArgsParameterFilesFromTemplateItem>), IList<UpdateDocumentArgsParameterFilesItem> files = default(IList<UpdateDocumentArgsParameterFilesItem>), IList<UpdateDocumentArgsParameterRemarksItem> remarks = default(IList<UpdateDocumentArgsParameterRemarksItem>), string project = default(string), IList<UpdateDocumentArgsParameterAdditionalFieldsItem> additionalFields = default(IList<UpdateDocumentArgsParameterAdditionalFieldsItem>), IList<UpdateDocumentArgsParameterEstatesItem> estates = default(IList<UpdateDocumentArgsParameterEstatesItem>), string revisionStatus = default(string), string subArchive = default(string), IList<UpdateDocumentArgsParameterArchiveCodesItem> archiveCodes = default(IList<UpdateDocumentArgsParameterArchiveCodesItem>), string recordType = default(string))
        {
            DocumentNumber = documentNumber;
            SyncDocumentContacts = syncDocumentContacts;
            ADContextUser = aDContextUser;
            Title = title;
            UnofficialTitle = unofficialTitle;
            DocumentDate = documentDate;
            Category = category;
            Status = status;
            AccessCode = accessCode;
            AccessGroup = accessGroup;
            ResponsiblePersonRecno = responsiblePersonRecno;
            ResponsiblePersonIdNumber = responsiblePersonIdNumber;
            ResponsiblePersonEmail = responsiblePersonEmail;
            ResponsiblePersonUserId = responsiblePersonUserId;
            ResponsibleEnterpriseRecno = responsibleEnterpriseRecno;
            ResponsibleEnterpriseNumber = responsibleEnterpriseNumber;
            Contacts = contacts;
            UnregisteredContacts = unregisteredContacts;
            SendersReference = sendersReference;
            Paragraph = paragraph;
            JournalDate = journalDate;
            DispatchedDate = dispatchedDate;
            FiledOnPaper = filedOnPaper;
            Notes = notes;
            ReferringCases = referringCases;
            ReferringDocuments = referringDocuments;
            Keywords = keywords;
            FilesFromTemplate = filesFromTemplate;
            Files = files;
            Remarks = remarks;
            Project = project;
            AdditionalFields = additionalFields;
            Estates = estates;
            RevisionStatus = revisionStatus;
            SubArchive = subArchive;
            ArchiveCodes = archiveCodes;
            RecordType = recordType;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentNumber")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SyncDocumentContacts")]
        public bool? SyncDocumentContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ADContextUser")]
        public string ADContextUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UnofficialTitle")]
        public string UnofficialTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentDate")]
        public DateTime? DocumentDate { get; set; }

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
        [JsonProperty(PropertyName = "AccessCode")]
        public string AccessCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessGroup")]
        public string AccessGroup { get; set; }

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
        [JsonProperty(PropertyName = "ResponsibleEnterpriseRecno")]
        public int? ResponsibleEnterpriseRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsibleEnterpriseNumber")]
        public string ResponsibleEnterpriseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contacts")]
        public IList<UpdateDocumentArgsParameterContactsItem> Contacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UnregisteredContacts")]
        public IList<UpdateDocumentArgsParameterUnregisteredContactsItem> UnregisteredContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SendersReference")]
        public string SendersReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Paragraph")]
        public string Paragraph { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JournalDate")]
        public DateTime? JournalDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DispatchedDate")]
        public DateTime? DispatchedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FiledOnPaper")]
        public bool? FiledOnPaper { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Notes")]
        public string Notes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferringCases")]
        public IList<UpdateDocumentArgsParameterReferringCasesItem> ReferringCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferringDocuments")]
        public IList<UpdateDocumentArgsParameterReferringDocumentsItem> ReferringDocuments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keywords")]
        public IList<string> Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilesFromTemplate")]
        public IList<UpdateDocumentArgsParameterFilesFromTemplateItem> FilesFromTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Files")]
        public IList<UpdateDocumentArgsParameterFilesItem> Files { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Remarks")]
        public IList<UpdateDocumentArgsParameterRemarksItem> Remarks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Project")]
        public string Project { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdditionalFields")]
        public IList<UpdateDocumentArgsParameterAdditionalFieldsItem> AdditionalFields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Estates")]
        public IList<UpdateDocumentArgsParameterEstatesItem> Estates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RevisionStatus")]
        public string RevisionStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubArchive")]
        public string SubArchive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ArchiveCodes")]
        public IList<UpdateDocumentArgsParameterArchiveCodesItem> ArchiveCodes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecordType")]
        public string RecordType { get; set; }

    }
}