namespace Ydb.Secret.V1;

public static partial class SecretService
{
    public static Grpc.Core.Method<Secret.DescribeSecretRequest, Secret.DescribeSecretResponse> DescribeSecretMethod
        => __Method_DescribeSecret;
}