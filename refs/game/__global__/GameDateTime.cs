public struct GameDateTime // TypeDefIndex: 639
{
	// Fields
	public int elapsedDays; // 0x0
	public int time; // 0x4

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(int _elapsedDays, int _time) { }

	// RVA: 0xA97FC0 Offset: 0xA969C0 VA: 0x180A97FC0
	public void .ctor(int _minSum) { }

	// RVA: 0xA97FA0 Offset: 0xA969A0 VA: 0x180A97FA0
	public void .ctor(GameDateTimeData data) { }

	// RVA: 0xA97F70 Offset: 0xA96970 VA: 0x180A97F70
	public int GetMinSum() { }

	// RVA: 0xA97EF0 Offset: 0xA968F0 VA: 0x180A97EF0
	public GameDateTime AddMins(int mins) { }

	// RVA: 0xA97F50 Offset: 0xA96950 VA: 0x180A97F50
	public GameDateTime GetCopy() { }

	// RVA: 0xA98080 Offset: 0xA96A80 VA: 0x180A98080
	public static GameDateTime op_Addition(GameDateTime a, GameDateTime b) { }

	// RVA: 0xA981C0 Offset: 0xA96BC0 VA: 0x180A981C0
	public static GameDateTime op_Subtraction(GameDateTime a, GameDateTime b) { }

	// RVA: 0xA98100 Offset: 0xA96B00 VA: 0x180A98100
	public static bool op_GreaterThan(GameDateTime a, GameDateTime b) { }

	// RVA: 0xA98160 Offset: 0xA96B60 VA: 0x180A98160
	public static bool op_LessThan(GameDateTime a, GameDateTime b) { }
}
