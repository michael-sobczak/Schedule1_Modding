using MelonLoader;

namespace S1API.Logging;

public class Log
{
	private readonly Instance _loggerInstance;

	public Log(string sourceName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		_loggerInstance = new Instance(sourceName);
	}

	public void Msg(string message)
	{
		_loggerInstance.Msg(message);
	}

	public void Warning(string message)
	{
		_loggerInstance.Warning(message);
	}

	public void Error(string message)
	{
		_loggerInstance.Error(message);
	}

	public void BigError(string message)
	{
		_loggerInstance.BigError(message);
	}
}
