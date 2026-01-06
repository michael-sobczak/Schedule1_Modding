public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 4150
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	[Conditional("MONO_FEATURE_CAS")]
	// RVA: 0x1ACA6C0 Offset: 0x1AC90C0 VA: 0x181ACA6C0 Slot: 7
	public void Demand() { }

	[ComVisible(False)]
	// RVA: 0x1ACA6F0 Offset: 0x1AC90F0 VA: 0x181ACA6F0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x1ACA840 Offset: 0x1AC9240 VA: 0x181ACA840 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x1ACA600 Offset: 0x1AC9000 VA: 0x181ACA600
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	private void System.Security.IPermission.Demand() { }
}
