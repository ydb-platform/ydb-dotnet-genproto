namespace Ydb.Import.V1;

public static partial class ImportService
{
    public static Grpc.Core.Method<Import.ImportFromS3Request, Import.ImportFromS3Response> ImportFromS3Method
        => __Method_ImportFromS3;

    public static Grpc.Core.Method<Import.ImportFromFsRequest, Import.ImportFromFsResponse> ImportFromFsMethod
        => __Method_ImportFromFs;

    public static Grpc.Core.Method<Import.ListObjectsInS3ExportRequest, Import.ListObjectsInS3ExportResponse> ListObjectsInS3ExportMethod
        => __Method_ListObjectsInS3Export;

    public static Grpc.Core.Method<Import.ListObjectsInFsExportRequest, Import.ListObjectsInFsExportResponse> ListObjectsInFsExportMethod
        => __Method_ListObjectsInFsExport;

    public static Grpc.Core.Method<Import.ImportDataRequest, Import.ImportDataResponse> ImportDataMethod
        => __Method_ImportData;
}