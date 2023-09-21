namespace Ydb.Operation.V1;

public static partial class OperationService
{
    public static Grpc.Core.Method<Operations.GetOperationRequest, Operations.GetOperationResponse> GetOperationMethod
        => __Method_GetOperation;

    public static Grpc.Core.Method<Operations.CancelOperationRequest, Operations.CancelOperationResponse> CancelOperationMethod
        => __Method_CancelOperation;

    public static Grpc.Core.Method<Operations.ForgetOperationRequest, Operations.ForgetOperationResponse> ForgetOperationMethod
        => __Method_ForgetOperation;

    public static Grpc.Core.Method<Operations.ListOperationsRequest, Operations.ListOperationsResponse> ListOperationsMethod
        => __Method_ListOperations;
}