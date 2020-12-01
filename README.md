**The problem: Paket does not add binding redirects for FSharp.Core 5.0.0.0, however it does it for version 4.6.0.0**

Build the solution.

Run `packages\NUnit.ConsoleRunner\tools\nunit3-console.exe TestProject1\bin\Debug\TestProject1.dll` (or use your favorite IDE's test runner)
Result:

```
NUnit Console Runner 3.11.1 (.NET 2.0)
Copyright (c) 2020 Charlie Poole, Rob Prouse
1 декабря 2020 г. 14:31:30

Runtime Environment
   OS Version: Microsoft Windows NT 6.2.9200.0
   Runtime: .NET Framework CLR v4.0.30319.42000

Test Files
    TestProject1\bin\Debug\TestProject1.dll


Errors, Failures and Warnings

1) Error : TestProject1.Tests.Test1
System.TypeInitializationException : The type initializer for '<StartupCode$FSharpCore5PaketRedirectionBug>.$Settings' threw an exception.
  ----> System.IO.FileLoadException : Could not load file or assembly 'FSharp.Core, Version=4.4.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The located assembly's manifest definition does not match the assembl
y reference. (Exception from HRESULT: 0x80131040)
   at FSharpCore5PaketRedirectionBug.Settings.get_Default()
   at TestProject1.Tests.Test1() in C:\WLCR\github\FSharpCore5PaketRedirectionBug\TestProject1\Tests.cs:line 13
--FileLoadException
   at FSharp.Configuration.YamlConfigTypeProvider.Root..ctor(Boolean inferTypesFromStrings)
   at FSharpCore5PaketRedirectionBug.SettingsType..ctor()
   at <StartupCode$FSharpCore5PaketRedirectionBug>.$Settings..cctor() in C:\WLCR\github\FSharpCore5PaketRedirectionBug\FSharpCore5PaketRedirectionBug\Settings.fs:line 8

Run Settings
    DisposeRunners: True
    WorkDirectory: C:\WLCR\github\FSharpCore5PaketRedirectionBug
    ImageRuntimeVersion: 4.0.30319
    ImageTargetFrameworkName: .NETFramework,Version=v4.6.2
    ImageRequiresX86: False
    ImageRequiresDefaultAppDomainAssemblyResolver: False
    RuntimeFramework: net-4.0
    NumberOfTestWorkers: 8

Test Run Summary
  Overall result: Failed
  Test Count: 1, Passed: 0, Failed: 1, Warnings: 0, Inconclusive: 0, Skipped: 0
    Failed Tests - Failures: 0, Errors: 1, Invalid: 0
  Start time: 2020-12-01 11:31:31Z
    End time: 2020-12-01 11:31:32Z
    Duration: 1.022 seconds

Results (nunit3) saved as TestResult.xml
```

Uncomment the binding redirect in TestProject1\app.config, rebuild, rerun the tests. Success.
