// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/comments.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Comment
  {
    static readonly string __ServiceName = "Comment";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.CommentLookupModel> __Marshaller_CommentLookupModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.CommentLookupModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.CommentModel> __Marshaller_CommentModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.CommentModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.NewCommentRequest> __Marshaller_NewCommentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.NewCommentRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.CommentLookupModel, global::GrpcServer.CommentModel> __Method_GetCommentInfo = new grpc::Method<global::GrpcServer.CommentLookupModel, global::GrpcServer.CommentModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCommentInfo",
        __Marshaller_CommentLookupModel,
        __Marshaller_CommentModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.NewCommentRequest, global::GrpcServer.CommentModel> __Method_GetNewComments = new grpc::Method<global::GrpcServer.NewCommentRequest, global::GrpcServer.CommentModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetNewComments",
        __Marshaller_NewCommentRequest,
        __Marshaller_CommentModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.CommentsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Comment</summary>
    [grpc::BindServiceMethod(typeof(Comment), "BindService")]
    public abstract partial class CommentBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.CommentModel> GetCommentInfo(global::GrpcServer.CommentLookupModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetNewComments(global::GrpcServer.NewCommentRequest request, grpc::IServerStreamWriter<global::GrpcServer.CommentModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CommentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCommentInfo, serviceImpl.GetCommentInfo)
          .AddMethod(__Method_GetNewComments, serviceImpl.GetNewComments).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CommentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCommentInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.CommentLookupModel, global::GrpcServer.CommentModel>(serviceImpl.GetCommentInfo));
      serviceBinder.AddMethod(__Method_GetNewComments, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcServer.NewCommentRequest, global::GrpcServer.CommentModel>(serviceImpl.GetNewComments));
    }

  }
}
#endregion
