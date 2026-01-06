public sealed class AndroidJavaException : Exception // TypeDefIndex: 18331
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x2C6A790 Offset: 0x2C69190 VA: 0x182C6A790
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x2C6A810 Offset: 0x2C69210 VA: 0x182C6A810 Slot: 9
	public override string get_StackTrace() { }
}
