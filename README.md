
How to build:

```
dotnet build -o output_pdb
git clean -dxf
dotnet build -o output_embedded -p:DebugType=embedded
```