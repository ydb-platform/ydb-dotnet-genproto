namespace Ydb.RateLimiter.V1;

public static partial class RateLimiterService
{
    public static Grpc.Core.Method<CreateResourceRequest, CreateResourceResponse> CreateResourceMethod => __Method_CreateResource;

    public static Grpc.Core.Method<AlterResourceRequest, AlterResourceResponse> AlterResourceMethod => __Method_AlterResource;

    public static Grpc.Core.Method<DropResourceRequest, DropResourceResponse> DropResourceMethod => __Method_DropResource;

    public static Grpc.Core.Method<ListResourcesRequest, ListResourcesResponse> ListResourcesMethod => __Method_ListResources;

    public static Grpc.Core.Method<DescribeResourceRequest, DescribeResourceResponse> DescribeResourceMethod => __Method_DescribeResource;

    public static Grpc.Core.Method<AcquireResourceRequest, AcquireResourceResponse> AcquireResourceMethod => __Method_AcquireResource;
}