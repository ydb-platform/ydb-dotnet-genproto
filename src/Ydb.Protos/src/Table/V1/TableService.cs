namespace Ydb.Table.V1;

public static partial class TableService
{
    public static Grpc.Core.Method<Table.CreateSessionRequest, Table.CreateSessionResponse> CreateSessionMethod => __Method_CreateSession;

    public static Grpc.Core.Method<Table.DeleteSessionRequest, Table.DeleteSessionResponse> DeleteSessionMethod => __Method_DeleteSession;

    public static Grpc.Core.Method<Table.KeepAliveRequest, Table.KeepAliveResponse> KeepAliveMethod => __Method_KeepAlive;

    public static Grpc.Core.Method<Table.CreateTableRequest, Table.CreateTableResponse> CreateTableMethod => __Method_CreateTable;

    public static Grpc.Core.Method<Table.DropTableRequest, Table.DropTableResponse> DropTableMethod => __Method_DropTable;

    public static Grpc.Core.Method<Table.AlterTableRequest, Table.AlterTableResponse> AlterTableMethod => __Method_AlterTable;

    public static Grpc.Core.Method<Table.CopyTableRequest, Table.CopyTableResponse> CopyTableMethod => __Method_CopyTable;

    public static Grpc.Core.Method<Table.CopyTablesRequest, Table.CopyTablesResponse> CopyTablesMethod => __Method_CopyTables;

    public static Grpc.Core.Method<Table.RenameTablesRequest, Table.RenameTablesResponse> RenameTablesMethod => __Method_RenameTables;

    public static Grpc.Core.Method<Table.DescribeTableRequest, Table.DescribeTableResponse> DescribeTableMethod => __Method_DescribeTable;

    public static Grpc.Core.Method<Table.ExplainDataQueryRequest, Table.ExplainDataQueryResponse> ExplainDataQueryMethod => __Method_ExplainDataQuery;

    public static Grpc.Core.Method<Table.PrepareDataQueryRequest, Table.PrepareDataQueryResponse> PrepareDataQueryMethod => __Method_PrepareDataQuery;

    public static Grpc.Core.Method<Table.ExecuteDataQueryRequest, Table.ExecuteDataQueryResponse> ExecuteDataQueryMethod => __Method_ExecuteDataQuery;

    public static Grpc.Core.Method<Table.ExecuteSchemeQueryRequest, Table.ExecuteSchemeQueryResponse> ExecuteSchemeQueryMethod => __Method_ExecuteSchemeQuery;

    public static Grpc.Core.Method<Table.BeginTransactionRequest, Table.BeginTransactionResponse> BeginTransactionMethod => __Method_BeginTransaction;

    public static Grpc.Core.Method<Table.CommitTransactionRequest, Table.CommitTransactionResponse> CommitTransactionMethod => __Method_CommitTransaction;

    public static Grpc.Core.Method<Table.RollbackTransactionRequest, Table.RollbackTransactionResponse> RollbackTransactionMethod => __Method_RollbackTransaction;

    public static Grpc.Core.Method<Table.DescribeTableOptionsRequest, Table.DescribeTableOptionsResponse> DescribeTableOptionsMethod => __Method_DescribeTableOptions;

    public static Grpc.Core.Method<Table.ReadTableRequest, Table.ReadTableResponse> StreamReadTableMethod => __Method_StreamReadTable;

    public static Grpc.Core.Method<Table.BulkUpsertRequest, Table.BulkUpsertResponse> BulkUpsertMethod => __Method_BulkUpsert;

    public static Grpc.Core.Method<Table.ExecuteScanQueryRequest, Table.ExecuteScanQueryPartialResponse> StreamExecuteScanQueryMethod => __Method_StreamExecuteScanQuery;
}