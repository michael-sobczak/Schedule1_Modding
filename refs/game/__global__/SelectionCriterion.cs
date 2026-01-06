internal abstract class SelectionCriterion // TypeDefIndex: 16597
{
	// Fields
	[CompilerGenerated]
	private bool <Verbose>k__BackingField; // 0x10

	// Properties
	internal virtual bool Verbose { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40 Slot: 4
	internal virtual bool get_Verbose() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80 Slot: 5
	internal virtual void set_Verbose(bool value) { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool Evaluate(string filename);

	[Conditional("SelectorTrace")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected static void CriterionTrace(string format, object[] args) { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract bool Evaluate(ZipEntry entry);
}
