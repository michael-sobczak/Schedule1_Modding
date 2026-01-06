public class TimedAccessZone : AccessZone // TypeDefIndex: 3368
{
	// Fields
	[Header("Timing Settings")]
	public int OpenTime; // 0x48
	public int CloseTime; // 0x4C

	// Methods

	// RVA: 0xA5C8E0 Offset: 0xA5B2E0 VA: 0x180A5C8E0 Slot: 6
	protected virtual void Start() { }

	// RVA: 0xA5C8A0 Offset: 0xA5B2A0 VA: 0x180A5C8A0 Slot: 7
	protected virtual void MinPass() { }

	// RVA: 0xA5C810 Offset: 0xA5B210 VA: 0x180A5C810 Slot: 8
	protected virtual bool GetIsOpen() { }

	// RVA: 0xA49140 Offset: 0xA47B40 VA: 0x180A49140
	public void .ctor() { }
}
