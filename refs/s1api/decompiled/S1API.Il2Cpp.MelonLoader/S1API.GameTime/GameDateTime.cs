using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;

namespace S1API.GameTime;

public struct GameDateTime
{
	public int ElapsedDays;

	public int Time;

	public GameDateTime(int elapsedDays, int time)
	{
		ElapsedDays = elapsedDays;
		Time = time;
	}

	public GameDateTime(int minSum)
	{
		ElapsedDays = minSum / 1440;
		int num = minSum % 1440;
		if (minSum < 0)
		{
			num = -minSum % 1440;
		}
		Time = TimeManager.Get24HourTimeFromMinSum(num);
	}

	public GameDateTime(GameDateTimeData data)
	{
		ElapsedDays = data.ElapsedDays;
		Time = data.Time;
	}

	public GameDateTime(GameDateTime gameDateTime)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		ElapsedDays = gameDateTime.elapsedDays;
		Time = gameDateTime.time;
	}

	public int GetMinSum()
	{
		return ElapsedDays * 1440 + TimeManager.GetMinSumFrom24HourTime(Time);
	}

	public GameDateTime AddMinutes(int minutes)
	{
		return new GameDateTime(GetMinSum() + minutes);
	}

	public GameDateTime ToS1()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		return new GameDateTime(ElapsedDays, Time);
	}

	public string GetFormattedTime()
	{
		return TimeManager.Get12HourTime((float)Time, true);
	}

	public bool IsNightTime()
	{
		return Time < 600 || Time >= 1800;
	}

	public bool IsSameDay(GameDateTime other)
	{
		return ElapsedDays == other.ElapsedDays;
	}

	public bool IsSameTime(GameDateTime other)
	{
		return ElapsedDays == other.ElapsedDays && Time == other.Time;
	}

	public override string ToString()
	{
		return $"Day {ElapsedDays}, {GetFormattedTime()}";
	}

	public static GameDateTime operator +(GameDateTime a, GameDateTime b)
	{
		return new GameDateTime(a.GetMinSum() + b.GetMinSum());
	}

	public static GameDateTime operator -(GameDateTime a, GameDateTime b)
	{
		return new GameDateTime(a.GetMinSum() - b.GetMinSum());
	}

	public static bool operator >(GameDateTime a, GameDateTime b)
	{
		return a.GetMinSum() > b.GetMinSum();
	}

	public static bool operator <(GameDateTime a, GameDateTime b)
	{
		return a.GetMinSum() < b.GetMinSum();
	}
}
