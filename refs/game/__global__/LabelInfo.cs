internal sealed class LabelInfo // TypeDefIndex: 15372
{
	// Fields
	private readonly LabelTarget _node; // 0x10
	private BranchLabel _label; // 0x18
	private object _definitions; // 0x20
	private readonly List<LabelScopeInfo> _references; // 0x28
	private bool _acrossBlockJump; // 0x30

	// Properties
	private bool HasDefinitions { get; }
	private bool HasMultipleDefinitions { get; }

	// Methods

	// RVA: 0x1FCD620 Offset: 0x1FCC020 VA: 0x181FCD620
	internal void .ctor(LabelTarget node) { }

	// RVA: 0x1FCD0C0 Offset: 0x1FCBAC0 VA: 0x181FCD0C0
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	// RVA: 0x1FCD110 Offset: 0x1FCBB10 VA: 0x181FCD110
	internal void Reference(LabelScopeInfo block) { }

	// RVA: 0x1FCCA00 Offset: 0x1FCB400 VA: 0x181FCCA00
	internal void Define(LabelScopeInfo block) { }

	// RVA: 0x1FCD260 Offset: 0x1FCBC60 VA: 0x181FCD260
	private void ValidateJump(LabelScopeInfo reference) { }

	// RVA: 0x1FCD1D0 Offset: 0x1FCBBD0 VA: 0x181FCD1D0
	internal void ValidateFinish() { }

	// RVA: 0x1FCCEA0 Offset: 0x1FCB8A0 VA: 0x181FCCEA0
	private void EnsureLabel(LightCompiler compiler) { }

	// RVA: 0x1FCCDF0 Offset: 0x1FCB7F0 VA: 0x181FCCDF0
	private bool DefinedIn(LabelScopeInfo scope) { }

	// RVA: 0x6208C0 Offset: 0x61F2C0 VA: 0x1806208C0
	private bool get_HasDefinitions() { }

	// RVA: 0x1FCCEF0 Offset: 0x1FCB8F0 VA: 0x181FCCEF0
	private LabelScopeInfo FirstDefinition() { }

	// RVA: 0x1FCC8C0 Offset: 0x1FCB2C0 VA: 0x181FCC8C0
	private void AddDefinition(LabelScopeInfo scope) { }

	// RVA: 0x1FCD6C0 Offset: 0x1FCC0C0 VA: 0x181FCD6C0
	private bool get_HasMultipleDefinitions() { }

	// RVA: -1 Offset: -1
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE8F10 Offset: 0xEE7910 VA: 0x180EE8F10
	|-LabelInfo.CommonNode<object>
	*/
}
