namespace Ydb.Auth.V1;

public static partial class AuthService
{
    public static Grpc.Core.Method<Auth.LoginRequest, Auth.LoginResponse> LoginMethod
        => __Method_Login;
}