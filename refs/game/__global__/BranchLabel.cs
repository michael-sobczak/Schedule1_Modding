internal sealed class BranchLabel // TypeDefIndex: 15245
{
	// Fields
	private int _targetIndex; // 0x10
	private int _stackDepth; // 0x14
	private int _continuationStackDepth; // 0x18
	private List<int> _forwardBranchFixups; // 0x20
	[CompilerGenerated]
	private int <LabelIndex>k__BackingField; // 0x28

	// Properties
	internal int LabelIndex { get; set; }
	internal bool HasRuntimeLabel { get; }
	internal int TargetIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	internal int get_LabelIndex() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	internal void set_LabelIndex(int value) { }

	// RVA: 0x1FA55E0 Offset: 0x1FA3FE0 VA: 0x181FA55E0
	internal bool get_HasRuntimeLabel() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal int get_TargetIndex() { }

	// RVA: 0x1FA5590 Offset: 0x1FA3F90 VA: 0x181FA5590
	internal RuntimeLabel ToRuntimeLabel() { }

	// RVA: 0x1FA5430 Offset: 0x1FA3E30 VA: 0x181FA5430
	internal void Mark(InstructionList instructions) { }

	// RVA: 0x1FA52D0 Offset: 0x1FA3CD0 VA: 0x181FA52D0
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1FA5400 Offset: 0x1FA3E00 VA: 0x181FA5400
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1FA55B0 Offset: 0x1FA3FB0 VA: 0x181FA55B0
	public void .ctor() { }
}
