namespace Ydb.Query.V1;

public static partial class QueryService
{
    public static Grpc.Core.Method<Query.CreateSessionRequest, Query.CreateSessionResponse> CreateSessionMethod
        => __Method_CreateSession;

    public static Grpc.Core.Method<Query.DeleteSessionRequest, Query.DeleteSessionResponse> DeleteSessionMethod
        => __Method_DeleteSession;

    public static Grpc.Core.Method<Query.AttachSessionRequest, Query.SessionState> AttachSessionMethod
        => __Method_AttachSession;

    public static Grpc.Core.Method<Query.BeginTransactionRequest, Query.BeginTransactionResponse> BeginTransactionMethod
        => __Method_BeginTransaction;

    public static Grpc.Core.Method<Query.CommitTransactionRequest, Query.CommitTransactionResponse> CommitTransactionMethod
        => __Method_CommitTransaction;

    public static Grpc.Core.Method<Query.RollbackTransactionRequest, Query.RollbackTransactionResponse> RollbackTransactionMethod
        => __Method_RollbackTransaction;

    public static Grpc.Core.Method<Query.ExecuteQueryRequest, Query.ExecuteQueryResponsePart> ExecuteQueryMethod
        => __Method_ExecuteQuery;

    public static Grpc.Core.Method<Query.ExecuteScriptRequest, Ydb.Operations.Operation> ExecuteScriptMethod
        => __Method_ExecuteScript;

    public static Grpc.Core.Method<Query.FetchScriptResultsRequest, Query.FetchScriptResultsResponse> FetchScriptResultsMethod
        => __Method_FetchScriptResults;
}