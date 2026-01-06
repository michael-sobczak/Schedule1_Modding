using System.Collections.Generic;

namespace S1API.Console;

public abstract class BaseConsoleCommand
{
	public abstract string CommandWord { get; }

	public abstract string CommandDescription { get; }

	public abstract string ExampleUsage { get; }

	public abstract void ExecuteCommand(List<string> args);
}
