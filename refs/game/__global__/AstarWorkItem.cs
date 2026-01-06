public struct AstarWorkItem // TypeDefIndex: 13190
{
	// Fields
	public Action init; // 0x0
	public Action<IWorkItemContext> initWithContext; // 0x8
	public Func<bool, bool> update; // 0x10
	public Func<IWorkItemContext, bool, bool> updateWithContext; // 0x18

	// Methods

	// RVA: 0xB15E80 Offset: 0xB14880 VA: 0x180B15E80
	public void .ctor(Func<bool, bool> update) { }

	// RVA: 0xB15EE0 Offset: 0xB148E0 VA: 0x180B15EE0
	public void .ctor(Func<IWorkItemContext, bool, bool> update) { }

	// RVA: 0xB15E20 Offset: 0xB14820 VA: 0x180B15E20
	public void .ctor(Action init, Func<bool, bool> update) { }

	// RVA: 0xB15F40 Offset: 0xB14940 VA: 0x180B15F40
	public void .ctor(Action<IWorkItemContext> init, Func<IWorkItemContext, bool, bool> update) { }
}
