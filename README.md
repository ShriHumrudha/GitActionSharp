[![.NET](https://github.com/ShriHumrudha/GitActionSharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ShriHumrudha/GitActionSharp/actions/workflows/dotnet.yml)
[![The Standard - COMPLIANT](https://img.shields.io/badge/The_Standard-COMPLIANT-2ea44f)](https://github.com/hassanhabib/The-Standard)

# GitActionSharp

<p align="center">
  <img width="25%" height="25%" src="https://github.com/ShriHumrudha/GitActionSharp/blob/main/GitActionSharp.jpg">
</p>

# Introduction
GitActionSharp (Git Actions in C#) is a .NET library enabling developers to develop any Git Action in C#.

# Example
```csharp
WorkflowClient workflowClient = new WorkflowClient();

var workflow = new Workflow
{
    Name = "Hello World!",
    On = "push",

    Jobs = new Job
    {
        Echo = new EchoJob
        {
            RunsOn = Machine.WindowsLatest,

            Steps = new List<GitActionTask>
            {
                new Echo
                {
                    Name = "Print",
                    Run = "echo My First Git Action using GitActionSharp."
                }
            }
        }
    }
};

workflowClient.CreateWorkflow("../../../../.github/workflows/echo.yml", workflow);
```

```YAML
name: Hello World!
on: push
jobs:
  echo:
    runs-on: windows-latest
    steps:
    - name: Print
      run: echo My First Git Action using GitActionSharp.
```

## Dependencies
[YamlDotNet](https://github.com/aaubry/YamlDotNet)

## Inspiration
[ADotNet](https://github.com/hassanhabib/ADotNet)
