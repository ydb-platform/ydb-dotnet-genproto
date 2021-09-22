using Ydb.Operations;

namespace Ydb.Operation.V1
{
    public static partial class OperationService
    {
        public static Grpc.Core.Method<GetOperationRequest, GetOperationResponse> GetOperationMethod
        {
            get { return __Method_GetOperation; }
        }

        public static Grpc.Core.Method<CancelOperationRequest, CancelOperationResponse> CancelOperationMethod
        {
            get { return __Method_CancelOperation; }
        }

        public static Grpc.Core.Method<ForgetOperationRequest, ForgetOperationResponse> ForgetOperationMethod
        {
            get { return __Method_ForgetOperation; }
        }

        public static Grpc.Core.Method<ListOperationsRequest, ListOperationsResponse> ListOperationsMethod
        {
            get { return __Method_ListOperations; }
        }
    }
}
