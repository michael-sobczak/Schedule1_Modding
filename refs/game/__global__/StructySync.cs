public class StructySync : SyncBase, ICustomSync // TypeDefIndex: 18100
{
	// Fields
	[CompilerGenerated]
	private StructySync.CustomChanged OnChange; // 0x50
	public Structy Value; // 0x58
	private Structy _initialValue; // 0x68
	private readonly List<StructySync.ChangeData> _changed; // 0x78
	private bool _valuesChanged; // 0x80
	private Structy _lastDirtied; // 0x88

	// Methods

	[CompilerGenerated]
	// RVA: 0xCF06B0 Offset: 0xCEF0B0 VA: 0x180CF06B0
	public void add_OnChange(StructySync.CustomChanged value) { }

	[CompilerGenerated]
	// RVA: 0xCF0750 Offset: 0xCEF150 VA: 0x180CF0750
	public void remove_OnChange(StructySync.CustomChanged value) { }

	// RVA: 0xCF01D0 Offset: 0xCEEBD0 VA: 0x180CF01D0 Slot: 12
	protected override void Registered() { }

	// RVA: 0xCEFD30 Offset: 0xCEE730 VA: 0x180CEFD30
	private void AddOperation(StructySync.CustomOperation operation, Structy prev, Structy next) { }

	// RVA: 0xCF0340 Offset: 0xCEED40 VA: 0x180CF0340 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }

	// RVA: 0xCF0580 Offset: 0xCEEF80 VA: 0x180CF0580 Slot: 17
	public override void WriteFull(PooledWriter writer) { }

	[APIExclude]
	// RVA: 0xCEFFF0 Offset: 0xCEE9F0 VA: 0x180CEFFF0 Slot: 19
	public override void Read(PooledReader reader, bool asServer) { }

	// RVA: 0xCF0280 Offset: 0xCEEC80 VA: 0x180CF0280
	public void ValuesChanged() { }

	// RVA: 0xCF0200 Offset: 0xCEEC00 VA: 0x180CF0200 Slot: 21
	public override void ResetState() { }

	// RVA: 0xCEFF90 Offset: 0xCEE990 VA: 0x180CEFF90 Slot: 22
	public object GetSerializedType() { }

	// RVA: 0xCF0630 Offset: 0xCEF030 VA: 0x180CF0630
	public void .ctor() { }
}
