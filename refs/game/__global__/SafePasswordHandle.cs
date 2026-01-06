internal sealed class SafePasswordHandle : SafeHandle // TypeDefIndex: 3543
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1AA63D0 Offset: 0x1AA4DD0 VA: 0x181AA63D0
	private IntPtr CreateHandle(string password) { }

	// RVA: 0x1AA6480 Offset: 0x1AA4E80 VA: 0x181AA6480
	private void FreeHandle() { }

	// RVA: 0x1AA65A0 Offset: 0x1AA4FA0 VA: 0x181AA65A0
	public void .ctor(string password) { }

	// RVA: 0x1AA6520 Offset: 0x1AA4F20 VA: 0x181AA6520 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1AA6420 Offset: 0x1AA4E20 VA: 0x181AA6420 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AA6610 Offset: 0x1AA5010 VA: 0x181AA6610 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1AA64D0 Offset: 0x1AA4ED0 VA: 0x181AA64D0
	internal string Mono_DangerousGetString() { }
}
