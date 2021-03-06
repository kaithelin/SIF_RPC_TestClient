﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SI.Shared.Sif.Testclient.Common
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// 
    /// SI.Data.RPC FileService
    /// 
    /// </summary>
    public partial interface IFileService : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


            /// <summary>
        /// 
        /// Just a ping method
        /// 
        /// </summary>
        /// <param name='pingArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PingWithHttpMessagesAsync(object pingArgs = default(object), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Checks out a file for external control, and retrieves the
        /// same file as a Stream. The file must later be checked in with the
        /// same user and external system, so use this method in combination
        /// with UploadAndCheckInFileFromExternalControl
        /// 
        /// </summary>
        /// <param name='checkOutAndGetFileForExternalControlArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CheckOutAndGetFileForExternalControlOKResponse>> CheckOutAndGetFileForExternalControlWithHttpMessagesAsync(CheckOutAndGetFileForExternalControlArgs checkOutAndGetFileForExternalControlArgs = default(CheckOutAndGetFileForExternalControlArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Streams a file to the 360° server, where it is checked in
        /// by the external system. This can be used on files that have been
        /// checked out with the method CheckOutAndGetFileForExternalControl.
        /// 
        /// </summary>
        /// <param name='uploadAndCheckInFileFromExternalControlArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<UploadAndCheckInFileFromExternalControlOKResponse>> UploadAndCheckInFileFromExternalControlWithHttpMessagesAsync(UploadAndCheckInFileFromExternalControlArgs uploadAndCheckInFileFromExternalControlArgs = default(UploadAndCheckInFileFromExternalControlArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Streams a file to the 360° server, where it is stored
        /// temporarily, and should be referred to in CreateDocument() or
        /// UpdateDocument().
        /// 
        /// </summary>
        /// <param name='uploadArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<UploadOKResponse>> UploadWithHttpMessagesAsync(UploadArgs uploadArgs = default(UploadArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Get file with meta data
        /// 
        /// </summary>
        /// <param name='getFileWithMetadataArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetFileWithMetadataOKResponse>> GetFileWithMetadataWithHttpMessagesAsync(GetFileWithMetadataArgs getFileWithMetadataArgs = default(GetFileWithMetadataArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// (none)
        /// </summary>
        /// <param name='getFilesWithMetadataArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetFilesWithMetadataOKResponse>> GetFilesWithMetadataWithHttpMessagesAsync(GetFilesWithMetadataArgs getFilesWithMetadataArgs = default(GetFilesWithMetadataArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Get the file as a Stream.
        /// 
        /// </summary>
        /// <param name='getFileArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetFileOKResponse>> GetFileWithHttpMessagesAsync(GetFileArgs getFileArgs = default(GetFileArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Creates New file
        /// 
        /// </summary>
        /// <param name='createFileArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CreateFileOKResponse>> CreateFileWithHttpMessagesAsync(CreateFileArgs createFileArgs = default(CreateFileArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Creates New file version and Updates properties of the
        /// file
        /// 
        /// </summary>
        /// <param name='updateFileArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<UpdateFileOKResponse>> UpdateFileWithHttpMessagesAsync(UpdateFileArgs updateFileArgs = default(UpdateFileArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// Delete File with given File Recno
        /// 
        /// </summary>
        /// <param name='deleteFileArgs'>
        /// (See model for parameter info)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<DeleteFileOKResponse>> DeleteFileWithHttpMessagesAsync(DeleteFileArgs deleteFileArgs = default(DeleteFileArgs), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
