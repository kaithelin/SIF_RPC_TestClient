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
    /// SignOffDocumentParameter
    /// </summary>
    public partial class SignOffDocumentArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the SignOffDocumentArgsParameter
        /// class.
        /// </summary>
        public SignOffDocumentArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the SignOffDocumentArgsParameter
        /// class.
        /// </summary>
        public SignOffDocumentArgsParameter(string aDContextUser = default(string), string document = default(string), string responseCode = default(string), string noteTitle = default(string), string note = default(string), string replyDocument = default(string))
        {
            ADContextUser = aDContextUser;
            Document = document;
            ResponseCode = responseCode;
            NoteTitle = noteTitle;
            Note = note;
            ReplyDocument = replyDocument;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ADContextUser")]
        public string ADContextUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Document")]
        public string Document { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponseCode")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NoteTitle")]
        public string NoteTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Note")]
        public string Note { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReplyDocument")]
        public string ReplyDocument { get; set; }

    }
}
