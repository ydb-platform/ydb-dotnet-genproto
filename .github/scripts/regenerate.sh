#!/bin/bash
find src/Ydb.Protos/src  -name "*.cs" -type f -delete # remove all old files

dotnet run --project src/Ydb.Protos/Codegen/Codegen.csproj ydb-api-protos src/Ydb.Protos/src # generate new