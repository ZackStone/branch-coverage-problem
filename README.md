# branch-coverage-problem

https://stackoverflow.com/questions/70398258/branch-coverage-never-reaches-100-net-unit-test

## Local Coverage

Using the VS Extension `Run Coverlet Report` to view the report about code coverage.

1. Install the nuget package `coverlet.msbuild` in the tests project:

```shell
dotnet add package coverlet.msbuild
```

2. Install the `ReportGenerator` tool. Run the commands bellow in a PowerShell with Administrator privileges.

```shell
dotnet tool install -g dotnet-reportgenerator-globaltool
dotnet tool install dotnet-reportgenerator-globaltool --tool-path tools
dotnet new tool-manifest
dotnet tool install dotnet-reportgenerator-globaltool
```

3. Install the Visual Studio extension `Run Coverlet Report`.

4. Restart all Visual Studio windows

5. Open the VS menu: `Tools > Options > Run Coverlet Report > Options` and change the `Integration type` to `MSBuild`.

6. Generating the report: Access the menu `Tools > Run Code Coverage`.