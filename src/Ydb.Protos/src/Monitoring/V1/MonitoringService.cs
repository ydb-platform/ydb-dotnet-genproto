namespace Ydb.Monitoring.V1;

public static partial class MonitoringService
{
    public static Grpc.Core.Method<Monitoring.SelfCheckRequest, Monitoring.SelfCheckResponse> SelfCheckMethod => __Method_SelfCheck;

    public static Grpc.Core.Method<Monitoring.NodeCheckRequest, Monitoring.NodeCheckResponse> NodeCheckMethod => __Method_NodeCheck;
}