public struct EstimatedTick // TypeDefIndex: 12815
{
	// Fields
	public uint LocalTick; // 0x0
	public uint RemoteTick; // 0x4
	public uint LastRemoteTick; // 0x8

	// Properties
	public bool IsUnset { get; }

	// Methods

	// RVA: 0xD929D0 Offset: 0xD913D0 VA: 0x180D929D0
	public bool IsCurrent(TimeManager tm) { }

	// RVA: 0xD92CF0 Offset: 0xD916F0 VA: 0x180D92CF0
	public bool get_IsUnset() { }

	// RVA: 0xD92A30 Offset: 0xD91430 VA: 0x180D92A30
	public uint LocalTickDifference(TimeManager tm) { }

	// RVA: 0xD92A90 Offset: 0xD91490 VA: 0x180D92A90
	public bool Update(TimeManager tm, uint remoteTick, EstimatedTick.OldTickOption oldTickOption = 0) { }

	// RVA: 0xD92B20 Offset: 0xD91520 VA: 0x180D92B20
	public uint Value(TimeManager tm) { }

	// RVA: 0xD92BF0 Offset: 0xD915F0 VA: 0x180D92BF0
	public uint Value(TimeManager tm, out bool isCurrent) { }

	// RVA: 0xD92A80 Offset: 0xD91480 VA: 0x180D92A80
	public void Reset() { }
}
