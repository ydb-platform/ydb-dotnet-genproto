#!/bin/bash
set -euxo pipefail

SOURCE_DIR=src/Ydb.Protos
PROTO_DIR=ydb-api-protos
CODEGEN_CSPROJ=codegen/Codegen.csproj

find $SOURCE_DIR  -name "*.cs" -type f -delete # remove all old files

dotnet run --project $CODEGEN_CSPROJ $PROTO_DIR $SOURCE_DIR # generate new

