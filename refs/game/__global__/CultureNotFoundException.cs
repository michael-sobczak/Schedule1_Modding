public class CultureNotFoundException : ArgumentException // TypeDefIndex: 4794
{
	// Fields
	private string _invalidCultureName; // 0x98
	private Nullable<int> _invalidCultureId; // 0xA0

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1BA0090 Offset: 0x1B9EA90 VA: 0x181BA0090
	public void .ctor() { }

	// RVA: 0x1BA0070 Offset: 0x1B9EA70 VA: 0x181BA0070
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1BA00D0 Offset: 0x1B9EAD0 VA: 0x181BA00D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B9FF20 Offset: 0x1B9E920 VA: 0x181B9FF20 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 16
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250 Slot: 17
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x1BA02B0 Offset: 0x1B9ECB0 VA: 0x181BA02B0
	private static string get_DefaultMessage() { }

	// RVA: 0x1BA02E0 Offset: 0x1B9ECE0 VA: 0x181BA02E0
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x1BA0400 Offset: 0x1B9EE00 VA: 0x181BA0400 Slot: 5
	public override string get_Message() { }
}
