public class PlayerPrefs // TypeDefIndex: 11769
{
	// Methods

	[NativeMethod("SetInt")]
	// RVA: 0x2CC37F0 Offset: 0x2CC21F0 VA: 0x182CC37F0
	private static bool TrySetInt(string key, int value) { }

	[NativeMethod("SetFloat")]
	// RVA: 0x2CC37A0 Offset: 0x2CC21A0 VA: 0x182CC37A0
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethod("SetString")]
	// RVA: 0x2CC3830 Offset: 0x2CC2230 VA: 0x182CC3830
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x2CC3680 Offset: 0x2CC2080 VA: 0x182CC3680
	public static void SetInt(string key, int value) { }

	// RVA: 0x2CC3480 Offset: 0x2CC1E80 VA: 0x182CC3480
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x2CC3440 Offset: 0x2CC1E40 VA: 0x182CC3440
	public static int GetInt(string key) { }

	// RVA: 0x2CC35F0 Offset: 0x2CC1FF0 VA: 0x182CC35F0
	public static void SetFloat(string key, float value) { }

	// RVA: 0x2CC33F0 Offset: 0x2CC1DF0 VA: 0x182CC33F0
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x2CC3710 Offset: 0x2CC2110 VA: 0x182CC3710
	public static void SetString(string key, string value) { }

	// RVA: 0x2CC3530 Offset: 0x2CC1F30 VA: 0x182CC3530
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x2CC34C0 Offset: 0x2CC1EC0 VA: 0x182CC34C0
	public static string GetString(string key) { }

	// RVA: 0x2CC3580 Offset: 0x2CC1F80 VA: 0x182CC3580
	public static bool HasKey(string key) { }

	// RVA: 0x2CC33B0 Offset: 0x2CC1DB0 VA: 0x182CC33B0
	public static void DeleteKey(string key) { }

	[NativeMethod("Sync")]
	// RVA: 0x2CC35C0 Offset: 0x2CC1FC0 VA: 0x182CC35C0
	public static void Save() { }
}
