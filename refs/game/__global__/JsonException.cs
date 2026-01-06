public class JsonException : Exception // TypeDefIndex: 10994
{
	// Methods

	// RVA: 0x1D0DC80 Offset: 0x1D0C680 VA: 0x181D0DC80
	public void .ctor() { }

	// RVA: 0x1D0DCD0 Offset: 0x1D0C6D0 VA: 0x181D0DCD0
	public void .ctor(string message) { }

	// RVA: 0x1D0DD30 Offset: 0x1D0C730 VA: 0x181D0DD30
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D0DDA0 Offset: 0x1D0C7A0 VA: 0x181D0DDA0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D0DBB0 Offset: 0x1D0C5B0 VA: 0x181D0DBB0
	internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message) { }
}
