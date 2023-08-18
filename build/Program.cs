using static Bullseye.Targets;
using static SimpleExec.Command;

Target("clean", () => RunAsync("dotnet", "clean -c Release -v m --nologo"));
Target("build", DependsOn("clean"),() => RunAsync("dotnet", "build -c Release --nologo --verbosity quiet"));
Target("test", DependsOn("build"), () => RunAsync("dotnet", "test -c Release --no-build --nologo --verbosity quiet"));
Target("default", DependsOn("test"));

await RunTargetsAndExitAsync(args, ex => ex is SimpleExec.ExitCodeException);
