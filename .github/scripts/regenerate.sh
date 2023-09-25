#!/bin/bash
set -euxo pipefail

SOURCE_DIR=src/Ydb.Protos
PROTO_DIR=ydb-api-protos
CODEGEN_CSPROJ=src/Codegen/Codegen.csproj

find $SOURCE_DIR  -name "*.cs" -type f -delete # remove all old files

dotnet run --project src/Codegen/Codegen.csproj $PROTO_DIR $SOURCE_DIR # generate new

