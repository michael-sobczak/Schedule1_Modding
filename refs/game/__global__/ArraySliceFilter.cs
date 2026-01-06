internal class ArraySliceFilter : PathFilter // TypeDefIndex: 11368
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Start>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <End>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <Step>k__BackingField; // 0x20

	// Properties
	public Nullable<int> Start { get; set; }
	public Nullable<int> End { get; set; }
	public Nullable<int> Step { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Nullable<int> get_Start() { }

	[CompilerGenerated]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void set_Start(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Nullable<int> get_End() { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_End(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Nullable<int> get_Step() { }

	[CompilerGenerated]
	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	public void set_Step(Nullable<int> value) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(ArraySliceFilter.<ExecuteFilter>d__12))]
	// RVA: 0x1DD0AD0 Offset: 0x1DCF4D0 VA: 0x181DD0AD0 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	// RVA: 0x1DD0B80 Offset: 0x1DCF580 VA: 0x181DD0B80
	private bool IsValid(int index, int stopIndex, bool positiveStep) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
