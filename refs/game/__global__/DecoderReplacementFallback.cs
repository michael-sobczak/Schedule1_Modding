public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable // TypeDefIndex: 4104
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1AB5E70 Offset: 0x1AB4870 VA: 0x181AB5E70
	public void .ctor() { }

	// RVA: 0x1AB5EB0 Offset: 0x1AB48B0 VA: 0x181AB5EB0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB5E10 Offset: 0x1AB4810 VA: 0x181AB5E10 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB5F70 Offset: 0x1AB4970 VA: 0x181AB5F70
	public void .ctor(string replacement) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_DefaultString() { }

	// RVA: 0x1AB5D20 Offset: 0x1AB4720 VA: 0x181AB5D20 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1AB6110 Offset: 0x1AB4B10 VA: 0x181AB6110 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1AB5DA0 Offset: 0x1AB47A0 VA: 0x181AB5DA0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A67980 Offset: 0x1A66380 VA: 0x181A67980 Slot: 2
	public override int GetHashCode() { }
}
