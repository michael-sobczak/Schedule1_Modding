public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable // TypeDefIndex: 4115
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1AB82A0 Offset: 0x1AB6CA0 VA: 0x181AB82A0
	public void .ctor() { }

	// RVA: 0x1AB82E0 Offset: 0x1AB6CE0 VA: 0x181AB82E0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB8240 Offset: 0x1AB6C40 VA: 0x181AB8240 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB83A0 Offset: 0x1AB6DA0 VA: 0x181AB83A0
	public void .ctor(string replacement) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_DefaultString() { }

	// RVA: 0x1AB8140 Offset: 0x1AB6B40 VA: 0x181AB8140 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1AB6110 Offset: 0x1AB4B10 VA: 0x181AB6110 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1AB81D0 Offset: 0x1AB6BD0 VA: 0x181AB81D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A67980 Offset: 0x1A66380 VA: 0x181A67980 Slot: 2
	public override int GetHashCode() { }
}
