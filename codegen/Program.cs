using System.Text;
using System.Text.RegularExpressions;
using System.CommandLine;


var protoDirArgument = new Argument<string>("protoDir", "The directory where *.proto files located");
var outputDirArgument = new Argument<string>("outDir", "The directory where *.cs files will be generated");

var rootCommand = new RootCommand();
rootCommand.AddArgument(protoDirArgument);
rootCommand.AddArgument(outputDirArgument);
rootCommand.SetHandler(Codegen, protoDirArgument, outputDirArgument);

rootCommand.InvokeAsync(args);
void Codegen(string protoDir, string outDir)
{
    const string rpcMethodPattern =
        @"rpc\s+(\w*)\((?:stream\s+)?((?:\w*\.)*.*)\)\s+returns\s+\((?:stream\s+)?((?:\w*\.)*.*)\);";
    const string servicePattern = @"service (\w*)Service \{";

    var rpcMethodRegex = new Regex(rpcMethodPattern);
    var serviceRegex = new Regex(servicePattern);

    var protoFiles = Directory.GetFiles(protoDir, "*.proto");

    var methodsCount = 0;

    foreach (var protoFile in protoFiles)
    {
        var protoCode = File.ReadAllText(protoFile);
        var methodMatch = rpcMethodRegex.Match(protoCode);
        var serviceMatch = serviceRegex.Match(protoCode);
        var serviceName = serviceMatch.Groups[1];
        var sb = new StringBuilder(
            $"namespace Ydb.{serviceName}.V1;\n\npublic static partial class {serviceName}Service\n{{");
        while (methodMatch.Success)
        {
            var method = methodMatch.Groups[1];
            var request = methodMatch.Groups[2];
            var response = methodMatch.Groups[3];
            var codeLine =
                $"\n    public static Grpc.Core.Method<{request}, {response}> {method}Method\n        => __Method_{method};\n"
                    .Replace(".From", ".Types.From");
            sb.Append(codeLine);
            methodsCount++;
            methodMatch = methodMatch.NextMatch();
        }

        sb.Append('}');
        var savePath = $"{outDir}/{serviceName}/V1/{serviceName}Service.cs";
        File.WriteAllText(savePath, sb.ToString());
    }

    Console.WriteLine($"Files processed: {protoFiles.Length}");
    Console.WriteLine($"Methods generated: {methodsCount}");
}