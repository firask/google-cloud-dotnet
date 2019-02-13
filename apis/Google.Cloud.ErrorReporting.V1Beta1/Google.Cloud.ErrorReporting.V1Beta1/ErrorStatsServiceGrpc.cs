// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/clouderrorreporting/v1beta1/error_stats_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.ErrorReporting.V1Beta1 {
  /// <summary>
  /// An API for retrieving and managing error statistics as well as data for
  /// individual events.
  /// </summary>
  public static partial class ErrorStatsService
  {
    static readonly string __ServiceName = "google.devtools.clouderrorreporting.v1beta1.ErrorStatsService";

    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest> __Marshaller_ListGroupStatsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse> __Marshaller_ListGroupStatsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest> __Marshaller_ListEventsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse> __Marshaller_ListEventsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest> __Marshaller_DeleteEventsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse> __Marshaller_DeleteEventsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest, global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse> __Method_ListGroupStats = new grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest, global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListGroupStats",
        __Marshaller_ListGroupStatsRequest,
        __Marshaller_ListGroupStatsResponse);

    static readonly grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest, global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse> __Method_ListEvents = new grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest, global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListEvents",
        __Marshaller_ListEventsRequest,
        __Marshaller_ListEventsResponse);

    static readonly grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest, global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse> __Method_DeleteEvents = new grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest, global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteEvents",
        __Marshaller_DeleteEventsRequest,
        __Marshaller_DeleteEventsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.ErrorReporting.V1Beta1.ErrorStatsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ErrorStatsService</summary>
    public abstract partial class ErrorStatsServiceBase
    {
      /// <summary>
      /// Lists the specified groups.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse> ListGroupStats(global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists the specified events.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse> ListEvents(global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes all error events of a given project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse> DeleteEvents(global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ErrorStatsService</summary>
    public partial class ErrorStatsServiceClient : grpc::ClientBase<ErrorStatsServiceClient>
    {
      /// <summary>Creates a new client for ErrorStatsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ErrorStatsServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ErrorStatsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ErrorStatsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ErrorStatsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ErrorStatsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists the specified groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse ListGroupStats(global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGroupStats(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the specified groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse ListGroupStats(global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListGroupStats, null, options, request);
      }
      /// <summary>
      /// Lists the specified groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse> ListGroupStatsAsync(global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGroupStatsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the specified groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsResponse> ListGroupStatsAsync(global::Google.Cloud.ErrorReporting.V1Beta1.ListGroupStatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListGroupStats, null, options, request);
      }
      /// <summary>
      /// Lists the specified events.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse ListEvents(global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the specified events.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse ListEvents(global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListEvents, null, options, request);
      }
      /// <summary>
      /// Lists the specified events.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse> ListEventsAsync(global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the specified events.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsResponse> ListEventsAsync(global::Google.Cloud.ErrorReporting.V1Beta1.ListEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListEvents, null, options, request);
      }
      /// <summary>
      /// Deletes all error events of a given project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse DeleteEvents(global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes all error events of a given project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse DeleteEvents(global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteEvents, null, options, request);
      }
      /// <summary>
      /// Deletes all error events of a given project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse> DeleteEventsAsync(global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes all error events of a given project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsResponse> DeleteEventsAsync(global::Google.Cloud.ErrorReporting.V1Beta1.DeleteEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteEvents, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ErrorStatsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ErrorStatsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ErrorStatsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListGroupStats, serviceImpl.ListGroupStats)
          .AddMethod(__Method_ListEvents, serviceImpl.ListEvents)
          .AddMethod(__Method_DeleteEvents, serviceImpl.DeleteEvents).Build();
    }

  }
}
#endregion