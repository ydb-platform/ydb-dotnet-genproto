namespace Ydb.Export.V1;

public static partial class ExportService
{
    public static Grpc.Core.Method<Export.ExportToYtRequest, Export.ExportToYtResponse> ExportToYtMethod => __Method_ExportToYt;

    public static Grpc.Core.Method<Export.ExportToS3Request, Export.ExportToS3Response> ExportToS3Method => __Method_ExportToS3;
}