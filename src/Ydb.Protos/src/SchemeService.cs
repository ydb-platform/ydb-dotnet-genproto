namespace Ydb.Scheme.V1
{
    public static partial class SchemeService
    {
        public static Grpc.Core.Method<MakeDirectoryRequest, MakeDirectoryResponse> MakeDirectoryMethod
        {
            get { return __Method_MakeDirectory; }
        }

        public static Grpc.Core.Method<RemoveDirectoryRequest, RemoveDirectoryResponse> RemoveDirectoryMethod
        {
            get { return __Method_RemoveDirectory; }
        }

        public static Grpc.Core.Method<ListDirectoryRequest, ListDirectoryResponse> ListDirectoryMethod
        {
            get { return __Method_ListDirectory; }
        }

        public static Grpc.Core.Method<DescribePathRequest, DescribePathResponse> DescribePathMethod
        {
            get { return __Method_DescribePath; }
        }

        public static Grpc.Core.Method<ModifyPermissionsRequest, ModifyPermissionsResponse> ModifyPermissionsMethod
        {
            get { return __Method_ModifyPermissions; }
        }
    }
}
