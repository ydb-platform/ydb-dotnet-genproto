import os
import re

proto_dir = 'ydb-api-protos'
code_dir = 'src/Ydb.Protos/src/'

files = [file for file in os.listdir(proto_dir) if file.endswith('.proto')]

print(files)

x = 0
for filename in files:
    proto_path = f'{proto_dir}/{filename}'
    print(proto_path)

    code_methods = []
    with open(proto_path, 'r') as file:
        text = file.read()
    matches = re.findall(r'rpc (\w*)\((?:stream )?((?:\w*\.)*.*)\) returns \((?:stream )?((?:\w*\.)*.*)\);',
                         text)
    x += len(matches)
    service_name = re.search(r'service (\w*)Service \{', text).groups()[0]
    for match in matches:
        method = match[0]
        request = match[1]
        response = match[2]
        code_methods.append(
            f'    public static Grpc.Core.Method<{request}, {response}> {method}Method => __Method_{method};'.replace(
                '.From', '.Types.From'))
    print(x)
    nl = "\n"
    code_text = f'namespace Ydb.{service_name}.V1;\n' \
                f'\n' \
                f'public static partial class {service_name}Service\n' \
                f'{{\n' \
                f'{f"{nl}{nl}".join(code_methods)}\n' \
                f'}}'
    print(code_text)

    code_path = f'{code_dir}/{service_name}/V1/{service_name}Service.cs'
    os.makedirs(os.path.dirname(code_path), exist_ok=True)

    with open(code_path, "w") as file:
        file.write(code_text)
