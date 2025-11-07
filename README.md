# tASKmANAGER
https://github.com/Timerkhan5/tASKmANAGER
A small .NET console application for managing simple tasks stored in a local JSON file.

This repository contains the source code for a lightweight task manager written in C# targeting .NET 8.0. The app reads and writes tasks to a JSON file and includes basic examples and utilities for working with task data.

## Highlights

- Console-based task manager written in C# (.NET 8)
- Tasks are persisted in `tasks.json` (local file)
- Minimal dependencies — built with the SDK only

## Repository structure

```
tASKmANAGER/
	├─ tASKmANAGER.sln         # Solution file
	├─ tASKmANAGER/            # C# project
	│   ├─ Program.cs
	│   ├─ json_work.cs        # JSON reading/writing helpers
	│   └─ tasks.json (runtime)
	└─ README.md
```

Note: A runtime copy of `tasks.json` can be found under `tASKmANAGER/bin/Debug/net8.0/tasks.json` after building and running the project from Visual Studio or `dotnet run`.

## Prerequisites

- .NET 8 SDK (or compatible .NET 8 runtime for building and running)
- PowerShell or another shell for running commands on Windows

You can check your .NET SDK version with:

```powershell
dotnet --version
```

## Build

From the repository root, run the following in PowerShell:

```powershell
dotnet build .\tASKmANAGER\tASKmANAGER.sln -c Debug
```

This will compile the project and place build artifacts into `tASKmANAGER/tASKmANAGER/bin/Debug/net8.0/`.

## Run

Run the console app from the project folder:

```powershell
cd .\tASKmANAGER
dotnet run --project . -c Debug
```

After running, the application may create or update `tasks.json` in the output folder.

## Where are the tasks stored?

At runtime the app uses a JSON file named `tasks.json`. When running from the project with the default Debug configuration the file can be found at:

```
tASKmANAGER/tASKmANAGER/bin/Debug/net8.0/tasks.json
```

If you want the app to use a specific location, look through `json_work.cs` (or the code that handles JSON) and adjust the path or pass a parameter as supported by the application.

## Example usage

- Start the app and follow the console prompts to create, list, or complete tasks.
- Inspect `tasks.json` to verify saved tasks.

##URL
https://github.com/Timerkhan5/tASKmANAGER

