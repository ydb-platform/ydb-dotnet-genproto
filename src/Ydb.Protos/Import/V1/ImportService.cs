namespace Ydb.Import.V1;

public static partial class ImportService
{
    public static Grpc.Core.Method<Import.ImportFromS3Request, Import.ImportFromS3Response> ImportFromS3Method
        => __Method_ImportFromS3;

    public static Grpc.Core.Method<Import.ImportDataRequest, Import.ImportDataResponse> ImportDataMethod
        => __Method_ImportData;
}