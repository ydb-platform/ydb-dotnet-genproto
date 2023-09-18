namespace Ydb.Discovery.V1;

public static partial class DiscoveryService
{
    public static Grpc.Core.Method<Ydb.Discovery.ListEndpointsRequest, Ydb.Discovery.ListEndpointsResponse> ListEndpointsMethod => __Method_ListEndpoints;

    public static Grpc.Core.Method<Ydb.Discovery.WhoAmIRequest, Ydb.Discovery.WhoAmIResponse> WhoAmIMethod => __Method_WhoAmI;
}