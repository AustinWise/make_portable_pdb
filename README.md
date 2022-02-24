
How to build:

First, [install .NET 6](https://dotnet.microsoft.com/).

```
dotnet build -o output_pdb
git clean -dxf
dotnet build -o output_embedded -p:DebugType=embedded
```