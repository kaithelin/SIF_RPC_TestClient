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

    public partial class GetFileOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetFileOKResponse class.
        /// </summary>
        public GetFileOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the GetFileOKResponse class.
        /// </summary>
        public GetFileOKResponse(GetFileOKResponseVersion version = default(GetFileOKResponseVersion), GetFileOKResponseContent content = default(GetFileOKResponseContent), string statusCode = default(string), string reasonPhrase = default(string), IList<GetFileOKResponseHeadersItem> headers = default(IList<GetFileOKResponseHeadersItem>), GetFileOKResponseRequestMessage requestMessage = default(GetFileOKResponseRequestMessage), bool? isSuccessStatusCode = default(bool?))
        {
            Version = version;
            Content = content;
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
            Headers = headers;
            RequestMessage = requestMessage;
            IsSuccessStatusCode = isSuccessStatusCode;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public GetFileOKResponseVersion Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Content")]
        public GetFileOKResponseContent Content { get; set; }

        /// <summary>
        /// Possible values include: 'Continue', 'SwitchingProtocols', 'OK',
        /// 'Created', 'Accepted', 'NonAuthoritativeInformation',
        /// 'NoContent', 'ResetContent', 'PartialContent', 'MultipleChoices',
        /// 'Ambiguous', 'MovedPermanently', 'Moved', 'Found', 'Redirect',
        /// 'SeeOther', 'RedirectMethod', 'NotModified', 'UseProxy',
        /// 'Unused', 'TemporaryRedirect', 'RedirectKeepVerb', 'BadRequest',
        /// 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable',
        /// 'ProxyAuthenticationRequired', 'RequestTimeout', 'Conflict',
        /// 'Gone', 'LengthRequired', 'PreconditionFailed',
        /// 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'UpgradeRequired', 'InternalServerError',
        /// 'NotImplemented', 'BadGateway', 'ServiceUnavailable',
        /// 'GatewayTimeout', 'HttpVersionNotSupported'
        /// </summary>
        [JsonProperty(PropertyName = "StatusCode")]
        public string StatusCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReasonPhrase")]
        public string ReasonPhrase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Headers")]
        public IList<GetFileOKResponseHeadersItem> Headers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequestMessage")]
        public GetFileOKResponseRequestMessage RequestMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSuccessStatusCode")]
        public bool? IsSuccessStatusCode { get; set; }

    }
}
