namespace Ydb.Scripting.V1;

public static partial class ScriptingService
{
    public static Grpc.Core.Method<Scripting.ExecuteYqlRequest, Scripting.ExecuteYqlResponse> ExecuteYqlMethod
        => __Method_ExecuteYql;

    public static Grpc.Core.Method<Scripting.ExecuteYqlRequest, Scripting.ExecuteYqlPartialResponse> StreamExecuteYqlMethod
        => __Method_StreamExecuteYql;

    public static Grpc.Core.Method<Scripting.ExplainYqlRequest, Scripting.ExplainYqlResponse> ExplainYqlMethod
        => __Method_ExplainYql;
}