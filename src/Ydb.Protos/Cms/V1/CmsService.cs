namespace Ydb.Cms.V1;

public static partial class CmsService
{
    public static Grpc.Core.Method<Cms.CreateDatabaseRequest, Cms.CreateDatabaseResponse> CreateDatabaseMethod
        => __Method_CreateDatabase;

    public static Grpc.Core.Method<Cms.GetDatabaseStatusRequest, Cms.GetDatabaseStatusResponse> GetDatabaseStatusMethod
        => __Method_GetDatabaseStatus;

    public static Grpc.Core.Method<Cms.AlterDatabaseRequest, Cms.AlterDatabaseResponse> AlterDatabaseMethod
        => __Method_AlterDatabase;

    public static Grpc.Core.Method<Cms.ListDatabasesRequest, Cms.ListDatabasesResponse> ListDatabasesMethod
        => __Method_ListDatabases;

    public static Grpc.Core.Method<Cms.RemoveDatabaseRequest, Cms.RemoveDatabaseResponse> RemoveDatabaseMethod
        => __Method_RemoveDatabase;

    public static Grpc.Core.Method<Cms.DescribeDatabaseOptionsRequest, Cms.DescribeDatabaseOptionsResponse> DescribeDatabaseOptionsMethod
        => __Method_DescribeDatabaseOptions;
}