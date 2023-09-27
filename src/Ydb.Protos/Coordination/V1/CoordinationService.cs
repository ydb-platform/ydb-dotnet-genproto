namespace Ydb.Coordination.V1;

public static partial class CoordinationService
{
    public static Grpc.Core.Method<Coordination.SessionRequest, Coordination.SessionResponse> SessionMethod
        => __Method_Session;

    public static Grpc.Core.Method<Coordination.CreateNodeRequest, Coordination.CreateNodeResponse> CreateNodeMethod
        => __Method_CreateNode;

    public static Grpc.Core.Method<Coordination.AlterNodeRequest, Coordination.AlterNodeResponse> AlterNodeMethod
        => __Method_AlterNode;

    public static Grpc.Core.Method<Coordination.DropNodeRequest, Coordination.DropNodeResponse> DropNodeMethod
        => __Method_DropNode;

    public static Grpc.Core.Method<Coordination.DescribeNodeRequest, Coordination.DescribeNodeResponse> DescribeNodeMethod
        => __Method_DescribeNode;
}