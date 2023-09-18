#!/bin/bash
find .  -name "*.cs" -type f -delete # remove all old files

python codegen.py # generate new

git add .