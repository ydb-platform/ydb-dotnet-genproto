#!/bin/bash
set -euxo pipefail

CHANGELOG=$(cat "$CHANGELOG_FILE" | sed -e '/^## v.*$/,$d')
if [[ -z "$CHANGELOG" ]]
then
  echo "CHANGELOG empty"
  exit 1;
fi;

VERSION=$(grep -Eow "<Version>.*</Version>" "$VERSION_FILE" | grep -Eo "([0-9]+)\.([0-9]+)\.([0-9]+)")

MAJOR=$(echo "$VERSION" | cut -d. -f 1);
MINOR=$(echo "$VERSION" | cut -d. -f 2);
PATCH=$(echo "$VERSION" | cut -d. -f 3);

VERSION="$MAJOR.$MINOR.$PATCH"

LAST_TAG="v$MAJOR.$MINOR.$PATCH";
if [ "$VERSION_CHANGE" = "MINOR" ]
then
  MINOR=$((MINOR+1));
  PATCH=0;
fi;
if [ "$VERSION_CHANGE" = "PATCH" ]
then
  PATCH=$((PATCH+1));
fi;
if [ "$RELEASE_CANDIDATE" = true ]
then
  RC=$(git tag | grep "v$MAJOR.$MINOR.$PATCH-rc" | wc -l);
  TAG="v$MAJOR.$MINOR.$PATCH-rc$RC";
else
  sed -e "s/<Version>[0-9.]*<\/Version>/<Version>$VERSION<\/Version>/g" -i "$VERSION_FILE"
  git add "$VERSION_FILE";
  echo "## v$MAJOR.$MINOR.$PATCH" >> "$CHANGELOG_FILE".tmp
  cat "$CHANGELOG_FILE" >> "$CHANGELOG_FILE".tmp
  mv "$CHANGELOG_FILE".tmp "$CHANGELOG_FILE";
  git add "$CHANGELOG_FILE";
  git config --global user.email "robot@umbrella";
  git config --global user.name "robot";
  git commit -m "Release v$MAJOR.$MINOR.$PATCH";
  TAG="v$MAJOR.$MINOR.$PATCH";
fi;
git tag "$TAG"
git push --tags && git push
CHANGELOG="$CHANGELOG

Full Changelog: [$LAST_TAG...$TAG](https://github.com/ydb-platform/ydb-dotnet-sdk/compare/$LAST_TAG...$TAG)"
if [ "$RELEASE_CANDIDATE" = true ]
then
  gh release create -d "$TAG" -t "$TAG" --notes "$CHANGELOG"
else
  VERSION=$MAJOR.$MINOR.$PATCH
  cd src/Ydb.Protos
  dotnet pack -c Release -o out /p:Version="$VERSION"
  gh release create "$TAG" -t "$TAG" --notes "$CHANGELOG"
  dotnet nuget push out/Ydb.Sdk."$VERSION".nupkg \
    --skip-duplicate \
    --api-key "$NUGET_TOKEN" \
    --source https://api.nuget.org/v3/index.json
fi;

