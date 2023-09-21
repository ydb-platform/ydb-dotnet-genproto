namespace Ydb.Topic.V1;

public static partial class TopicService
{
    public static Grpc.Core.Method<StreamWriteMessage.Types.FromClient, StreamWriteMessage.Types.FromServer> StreamWriteMethod
        => __Method_StreamWrite;

    public static Grpc.Core.Method<StreamReadMessage.Types.FromClient, StreamReadMessage.Types.FromServer> StreamReadMethod
        => __Method_StreamRead;

    public static Grpc.Core.Method<CommitOffsetRequest, CommitOffsetResponse> CommitOffsetMethod
        => __Method_CommitOffset;

    public static Grpc.Core.Method<CreateTopicRequest, CreateTopicResponse> CreateTopicMethod
        => __Method_CreateTopic;

    public static Grpc.Core.Method<DescribeTopicRequest, DescribeTopicResponse> DescribeTopicMethod
        => __Method_DescribeTopic;

    public static Grpc.Core.Method<DescribeConsumerRequest, DescribeConsumerResponse> DescribeConsumerMethod
        => __Method_DescribeConsumer;

    public static Grpc.Core.Method<AlterTopicRequest, AlterTopicResponse> AlterTopicMethod
        => __Method_AlterTopic;

    public static Grpc.Core.Method<DropTopicRequest, DropTopicResponse> DropTopicMethod
        => __Method_DropTopic;
}