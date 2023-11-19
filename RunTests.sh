#!/bin/bash

if [[ "$OSTYPE" == "msys" || "$OSTYPE" == "win32" ]]; then
    dotnet test TestAutomationFramework.csproj
else
    dotnet test TestAutomationFramework.csproj
fi