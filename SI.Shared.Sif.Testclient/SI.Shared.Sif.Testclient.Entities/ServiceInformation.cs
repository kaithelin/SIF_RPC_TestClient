﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    public class ServiceInformation
    {
        public Credentials Credentials { get; private set; }
        public Uri SupportServiceUri { get; private set; }
        public Uri UserServiceUri { get; private set; }
        public Uri ContactServiceUri { get; private set; }
        public Uri DocumentServiceUri { get; private set; }
        public Uri FileServiceUri { get; private set; }
        public Uri ProjectServiceUri { get; private set; }
        public Uri CaseServiceUri { get; private set; }

        public ServiceInformation(string authkey, string baseUri)
        {
            //supportServiceUri, string userServiceUri, string contactServiceUri, string documentServiceUri
            if (string.IsNullOrEmpty(authkey))
            {
                throw new ArgumentException("authkey is empty");
            }

            if (string.IsNullOrEmpty(baseUri))
            {
                throw new ArgumentException("baseUri is empty");
            }

            try
            {
                Credentials = new Credentials(authkey);
                SupportServiceUri = new Uri($"{baseUri}/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/SupportService");
                UserServiceUri = new Uri($"{baseUri}/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/UserService");
                ContactServiceUri = new Uri($"{baseUri}/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/ContactService");
                DocumentServiceUri = new Uri($"{baseUri}/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/DocumentService");
                FileServiceUri = new Uri($"{baseUri}/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/FileService");
                ProjectServiceUri = new Uri($"{baseUri}/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/ProjectService");
                CaseServiceUri = new Uri($"{baseUri}/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/CaseService");
            }
            catch(Exception e)
            {
                throw new Exception("Somthing whent wrong when creating the ServiceInformation object, se inner exception for details", e);
            }
        }  
    }

    [JsonObject("ServiceInformation")]
    public class ServiceInformationList
    {
        [JsonProperty("Credentials")]
        public List<ServiceInformationCredentials> Credentials { get; set; }
    }

    [JsonObject("ServiceInformation")]
    public class ServiceInformationCredentials
    {
        [JsonProperty("authkey")]
        public string authkey { get; set; }

        [JsonProperty("baseUri")]
        public string baseUri { get; set; }

        [JsonProperty("Run")]
        public bool run { get; set; }
    }
}
