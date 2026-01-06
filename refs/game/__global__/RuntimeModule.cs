internal class RuntimeModule : Module // TypeDefIndex: 4760
{
	// Fields
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C

	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override Assembly get_Assembly() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 10
	public override string get_ScopeName() { }

	// RVA: 0x1B96690 Offset: 0x1B95090 VA: 0x181B96690 Slot: 9
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170 Slot: 11
	public override bool IsResource() { }

	// RVA: 0x1B96360 Offset: 0x1B94D60 VA: 0x181B96360 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B962F0 Offset: 0x1B94CF0 VA: 0x181B962F0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B965D0 Offset: 0x1B94FD0 VA: 0x181B965D0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B96450 Offset: 0x1B94E50 VA: 0x181B96450 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B96560 Offset: 0x1B94F60 VA: 0x181B96560
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1B963D0 Offset: 0x1B94DD0 VA: 0x181B963D0 Slot: 16
	internal override Guid GetModuleVersionId() { }

	// RVA: 0x1B963C0 Offset: 0x1B94DC0 VA: 0x181B963C0
	private static void GetGuidInternal(IntPtr module, byte[] guid) { }

	// RVA: 0x1B96640 Offset: 0x1B95040 VA: 0x181B96640
	public void .ctor() { }
}
