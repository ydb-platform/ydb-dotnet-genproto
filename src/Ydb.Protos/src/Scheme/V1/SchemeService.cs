namespace Ydb.Scheme.V1;

public static partial class SchemeService
{
    public static Grpc.Core.Method<Scheme.MakeDirectoryRequest, Scheme.MakeDirectoryResponse> MakeDirectoryMethod => __Method_MakeDirectory;

    public static Grpc.Core.Method<Scheme.RemoveDirectoryRequest, Scheme.RemoveDirectoryResponse> RemoveDirectoryMethod => __Method_RemoveDirectory;

    public static Grpc.Core.Method<Scheme.ListDirectoryRequest, Scheme.ListDirectoryResponse> ListDirectoryMethod => __Method_ListDirectory;

    public static Grpc.Core.Method<Scheme.DescribePathRequest, Scheme.DescribePathResponse> DescribePathMethod => __Method_DescribePath;

    public static Grpc.Core.Method<Scheme.ModifyPermissionsRequest, Scheme.ModifyPermissionsResponse> ModifyPermissionsMethod => __Method_ModifyPermissions;
}