internal struct InstructionArray // TypeDefIndex: 15364
{
	// Fields
	internal readonly int MaxStackDepth; // 0x0
	internal readonly int MaxContinuationDepth; // 0x4
	internal readonly Instruction[] Instructions; // 0x8
	internal readonly object[] Objects; // 0x10
	internal readonly RuntimeLabel[] Labels; // 0x18
	internal readonly List<KeyValuePair<int, object>> DebugCookies; // 0x20

	// Methods

	// RVA: 0x1FC6490 Offset: 0x1FC4E90 VA: 0x181FC6490
	internal void .ctor(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies) { }
}
