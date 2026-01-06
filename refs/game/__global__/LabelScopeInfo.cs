internal sealed class LabelScopeInfo // TypeDefIndex: 15374
{
	// Fields
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
	internal readonly LabelScopeKind Kind; // 0x18
	internal readonly LabelScopeInfo Parent; // 0x20

	// Properties
	internal bool CanJumpInto { get; }

	// Methods

	// RVA: 0x1FCD8F0 Offset: 0x1FCC2F0 VA: 0x181FCD8F0
	internal void .ctor(LabelScopeInfo parent, LabelScopeKind kind) { }

	// RVA: 0x1FCD940 Offset: 0x1FCC340 VA: 0x181FCD940
	internal bool get_CanJumpInto() { }

	// RVA: 0x1FCD800 Offset: 0x1FCC200 VA: 0x181FCD800
	internal bool ContainsTarget(LabelTarget target) { }

	// RVA: 0x1FCD860 Offset: 0x1FCC260 VA: 0x181FCD860
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

	// RVA: 0x1FCD740 Offset: 0x1FCC140 VA: 0x181FCD740
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }
}
