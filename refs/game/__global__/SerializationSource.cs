internal abstract class SerializationSource // TypeDefIndex: 8155
{
	// Fields
	private Type[] includedTypes; // 0x10
	private string namspace; // 0x18
	private bool canBeGenerated; // 0x20

	// Methods

	// RVA: 0x2522260 Offset: 0x2520C60 VA: 0x182522260
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x2522150 Offset: 0x2520B50 VA: 0x182522150
	protected bool BaseEquals(SerializationSource other) { }
}
