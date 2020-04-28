// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/post.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class RemotePost
  {
    static readonly string __ServiceName = "RemotePost";

    static readonly grpc::Marshaller<global::GrpcService.Protos.PostModel> __Marshaller_PostModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.PostModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.BoolResultMessage> __Marshaller_BoolResultMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.BoolResultMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.PostIdMessage> __Marshaller_PostIdMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.PostIdMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.IntResultMessage> __Marshaller_IntResultMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.IntResultMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.PostListMessage> __Marshaller_PostListMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.PostListMessage.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.BoolResultMessage> __Method_AddPost = new grpc::Method<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.BoolResultMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_PostModel,
        __Marshaller_BoolResultMessage);

    static readonly grpc::Method<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.PostModel> __Method_UpdatePost = new grpc::Method<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_PostModel,
        __Marshaller_PostModel);

    static readonly grpc::Method<global::GrpcService.Protos.PostIdMessage, global::GrpcService.Protos.IntResultMessage> __Method_DeletePost = new grpc::Method<global::GrpcService.Protos.PostIdMessage, global::GrpcService.Protos.IntResultMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_PostIdMessage,
        __Marshaller_IntResultMessage);

    static readonly grpc::Method<global::GrpcService.Protos.PostIdMessage, global::GrpcService.Protos.PostModel> __Method_GetPostById = new grpc::Method<global::GrpcService.Protos.PostIdMessage, global::GrpcService.Protos.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_PostIdMessage,
        __Marshaller_PostModel);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.Protos.PostListMessage> __Method_GetAllPosts = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.Protos.PostListMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPosts",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_PostListMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.PostReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemotePost</summary>
    [grpc::BindServiceMethod(typeof(RemotePost), "BindService")]
    public abstract partial class RemotePostBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.BoolResultMessage> AddPost(global::GrpcService.Protos.PostModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.PostModel> UpdatePost(global::GrpcService.Protos.PostModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.IntResultMessage> DeletePost(global::GrpcService.Protos.PostIdMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.PostModel> GetPostById(global::GrpcService.Protos.PostIdMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.PostListMessage> GetAllPosts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RemotePostBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_DeletePost, serviceImpl.DeletePost)
          .AddMethod(__Method_GetPostById, serviceImpl.GetPostById)
          .AddMethod(__Method_GetAllPosts, serviceImpl.GetAllPosts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RemotePostBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.BoolResultMessage>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.PostModel>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_DeletePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.PostIdMessage, global::GrpcService.Protos.IntResultMessage>(serviceImpl.DeletePost));
      serviceBinder.AddMethod(__Method_GetPostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.PostIdMessage, global::GrpcService.Protos.PostModel>(serviceImpl.GetPostById));
      serviceBinder.AddMethod(__Method_GetAllPosts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcService.Protos.PostListMessage>(serviceImpl.GetAllPosts));
    }

  }
}
#endregion