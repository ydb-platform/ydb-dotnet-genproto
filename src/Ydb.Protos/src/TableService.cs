namespace Ydb.Table.V1
{
    public static partial class TableService
    {
        public static Grpc.Core.Method<Ydb.Table.CreateSessionRequest, Ydb.Table.CreateSessionResponse> CreateSessionMethod
        {
            get { return __Method_CreateSession; }
        }

        public static Grpc.Core.Method<Ydb.Table.DeleteSessionRequest, Ydb.Table.DeleteSessionResponse> DeleteSessionMethod
        {
            get { return __Method_DeleteSession; }
        }

        public static Grpc.Core.Method<Ydb.Table.KeepAliveRequest, Ydb.Table.KeepAliveResponse> KeepAliveMethod
        {
            get { return __Method_KeepAlive; }
        }

        public static Grpc.Core.Method<CreateTableRequest, CreateTableResponse> CreateTableMethod
        {
            get { return __Method_CreateTable; }
        }

        public static Grpc.Core.Method<DropTableRequest, DropTableResponse> DropTableMethod
        {
            get { return __Method_DropTable; }
        }

        public static Grpc.Core.Method<Ydb.Table.AlterTableRequest, Ydb.Table.AlterTableResponse> AlterTableMethod
        {
            get { return __Method_AlterTable; }
        }

        public static Grpc.Core.Method<CopyTableRequest, CopyTableResponse> CopyTableMethod
        {
            get { return __Method_CopyTable; }
        }

        public static Grpc.Core.Method<CopyTablesRequest, CopyTablesResponse> CopyTablesMethod
        {
            get { return __Method_CopyTables; }
        }

        public static Grpc.Core.Method<RenameTablesRequest, RenameTablesResponse> RenameTablesMethod
        {
            get { return __Method_RenameTables; }
        }

        public static Grpc.Core.Method<DescribeTableRequest, DescribeTableResponse> DescribeTableMethod
        {
            get { return __Method_DescribeTable; }
        }

        public static Grpc.Core.Method<ExplainDataQueryRequest, ExplainDataQueryResponse> ExplainDataQueryMethod
        {
            get { return __Method_ExplainDataQuery; }
        }

        public static Grpc.Core.Method<PrepareDataQueryRequest, PrepareDataQueryResponse> PrepareDataQueryMethod
        {
            get { return __Method_PrepareDataQuery; }
        }

        public static Grpc.Core.Method<Ydb.Table.ExecuteDataQueryRequest, Ydb.Table.ExecuteDataQueryResponse> ExecuteDataQueryMethod
        {
            get { return __Method_ExecuteDataQuery; }
        }

        public static Grpc.Core.Method<ExecuteSchemeQueryRequest, ExecuteSchemeQueryResponse> ExecuteSchemeQueryMethod
        {
            get { return __Method_ExecuteSchemeQuery; }
        }

        public static Grpc.Core.Method<BeginTransactionRequest, BeginTransactionResponse> BeginTransactionMethod
        {
            get { return __Method_BeginTransaction; }
        }

        public static Grpc.Core.Method<CommitTransactionRequest, CommitTransactionResponse> CommitTransactionMethod
        {
            get { return __Method_CommitTransaction; }
        }

        public static Grpc.Core.Method<RollbackTransactionRequest, RollbackTransactionResponse> RollbackTransactionMethod
        {
            get { return __Method_RollbackTransaction; }
        }

        public static Grpc.Core.Method<DescribeTableOptionsRequest, DescribeTableOptionsResponse> DescribeTableOptionsMethod
        {
            get { return __Method_DescribeTableOptions; }
        }

        public static Grpc.Core.Method<Ydb.Table.ReadTableRequest, Ydb.Table.ReadTableResponse> StreamReadTableMethod
        {
            get { return __Method_StreamReadTable; }
        }

        public static Grpc.Core.Method<BulkUpsertRequest, BulkUpsertResponse> BulkUpsertMethod
        {
            get { return __Method_BulkUpsert; }
        }

        public static Grpc.Core.Method<Ydb.Table.ExecuteScanQueryRequest, Ydb.Table.ExecuteScanQueryPartialResponse> StreamExecuteScanQueryMethod
        {
            get { return __Method_StreamExecuteScanQuery; }
        }
    }
}
