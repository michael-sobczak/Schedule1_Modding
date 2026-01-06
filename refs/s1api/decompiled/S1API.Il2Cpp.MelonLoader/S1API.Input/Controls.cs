using Il2CppScheduleOne;

namespace S1API.Input;

public static class Controls
{
	public static bool IsTyping
	{
		get
		{
			return GameInput.IsTyping;
		}
		set
		{
			GameInput.IsTyping = value;
		}
	}
}
