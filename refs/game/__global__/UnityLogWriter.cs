internal class UnityLogWriter : TextWriter // TypeDefIndex: 11745
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x2CB6210 Offset: 0x2CB4C10 VA: 0x182CB6210
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CB61D0 Offset: 0x2CB4BD0 VA: 0x182CB61D0
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x2CB6130 Offset: 0x2CB4B30 VA: 0x182CB6130
	public static void Init() { }

	// RVA: 0x2CB63B0 Offset: 0x2CB4DB0 VA: 0x182CB63B0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2CB6290 Offset: 0x2CB4C90 VA: 0x182CB6290 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x2CB6250 Offset: 0x2CB4C50 VA: 0x182CB6250 Slot: 16
	public override void Write(string s) { }

	// RVA: 0x2CB6310 Offset: 0x2CB4D10 VA: 0x182CB6310 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2CB6360 Offset: 0x2CB4D60 VA: 0x182CB6360
	public void .ctor() { }
}
