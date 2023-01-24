#!/bin/bash

dotnet restore -s https://api.nuget.org/v3/index.json 
dotnet build