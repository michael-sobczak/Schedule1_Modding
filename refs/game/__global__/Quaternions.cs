public static class Quaternions // TypeDefIndex: 18178
{
	// Methods

	[Extension]
	// RVA: 0xDA9800 Offset: 0xDA8200 VA: 0x180DA9800
	public static float GetRate(Quaternion a, Quaternion goal, float duration, out float angle, uint interval = 1, float tolerance = 0) { }

	[Extension]
	// RVA: 0xDA98B0 Offset: 0xDA82B0 VA: 0x180DA98B0
	public static bool Matches(Quaternion a, Quaternion b, bool precise = False) { }

	[Extension]
	// RVA: 0xDA9710 Offset: 0xDA8110 VA: 0x180DA9710
	public static float Angle(Quaternion a, Quaternion b, bool precise = False) { }
}
