public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 9564
{
	// Fields
	[CompilerGenerated]
	private readonly string <Input>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly TimeSpan <MatchTimeout>k__BackingField; // 0xA0

	// Properties
	public string Input { get; }
	public string Pattern { get; }
	public TimeSpan MatchTimeout { get; }

	// Methods

	// RVA: 0x26303B0 Offset: 0x262EDB0 VA: 0x1826303B0
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x2630650 Offset: 0x262F050 VA: 0x182630650
	public void .ctor() { }

	// RVA: 0x26304D0 Offset: 0x262EED0 VA: 0x1826304D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x26302C0 Offset: 0x262ECC0 VA: 0x1826302C0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_Input() { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public TimeSpan get_MatchTimeout() { }
}
