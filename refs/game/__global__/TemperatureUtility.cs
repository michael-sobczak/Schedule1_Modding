public static class TemperatureUtility // TypeDefIndex: 672
{
	// Properties
	public static bool TemperatureSystemEnabled { get; }

	// Methods

	// RVA: 0xAC96D0 Offset: 0xAC80D0 VA: 0x180AC96D0
	public static bool get_TemperatureSystemEnabled() { }

	// RVA: 0xAC96B0 Offset: 0xAC80B0 VA: 0x180AC96B0
	public static float ToFahrenheit(float celsius) { }

	// RVA: 0xAC9380 Offset: 0xAC7D80 VA: 0x180AC9380
	public static string FormatCelsiusTemperature(float celsius, int decimalPoints) { }

	// RVA: 0xAC9420 Offset: 0xAC7E20 VA: 0x180AC9420
	public static string FormatFahrenheitTemperature(float fahrenheit, int decimalPoints) { }

	// RVA: 0xAC94C0 Offset: 0xAC7EC0 VA: 0x180AC94C0
	public static string FormatTemperatureWithAppropriateUnit(float celsius, int decimalPoints = 1) { }

	// RVA: 0xAC9680 Offset: 0xAC8080 VA: 0x180AC9680
	public static float NormalizeTemperature(float celsius) { }
}
