public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 19119
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VFXEventAttribute m_WrapEventAttribute; // 0x20

	// Methods

	// RVA: 0x2F5EC60 Offset: 0x2F5D660 VA: 0x182F5EC60
	internal void .ctor(IntPtr ptr, bool owner) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5E6F0 Offset: 0x2F5D0F0 VA: 0x182F5E6F0
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	// RVA: 0x2F5E9B0 Offset: 0x2F5D3B0 VA: 0x182F5E9B0
	private void PrepareWrapper() { }

	[RequiredByNativeCode]
	// RVA: 0x2F5EB40 Offset: 0x2F5D540 VA: 0x182F5EB40
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) { }

	// RVA: 0x2F5EAD0 Offset: 0x2F5D4D0 VA: 0x182F5EAD0
	private void Release() { }

	// RVA: 0x2F5E8B0 Offset: 0x2F5D2B0 VA: 0x182F5E8B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F5E800 Offset: 0x2F5D200 VA: 0x182F5E800 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F5E970 Offset: 0x2F5D370 VA: 0x182F5E970
	private static void Internal_Destroy(IntPtr ptr) { }
}
