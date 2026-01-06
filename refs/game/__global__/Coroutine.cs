public sealed class Coroutine : YieldInstruction // TypeDefIndex: 11815
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x2CBB7E0 Offset: 0x2CBA1E0 VA: 0x182CBB7E0 Slot: 1
	protected override void Finalize() { }

	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	// RVA: 0x2CBB860 Offset: 0x2CBA260 VA: 0x182CBB860
	private static void ReleaseCoroutine(IntPtr ptr) { }
}
