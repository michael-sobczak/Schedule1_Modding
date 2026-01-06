internal class LeaseManager // TypeDefIndex: 4311
{
	// Fields
	private ArrayList _objects; // 0x10
	private Timer _timer; // 0x18

	// Methods

	// RVA: 0x1B0EDE0 Offset: 0x1B0D7E0 VA: 0x181B0EDE0
	public void SetPollTime(TimeSpan timeSpan) { }

	// RVA: 0x1B0F070 Offset: 0x1B0DA70 VA: 0x181B0F070
	public void TrackLifetime(ServerIdentity identity) { }

	// RVA: 0x1B0EEB0 Offset: 0x1B0D8B0 VA: 0x181B0EEB0
	public void StartManager() { }

	// RVA: 0x1B0F030 Offset: 0x1B0DA30 VA: 0x181B0F030
	public void StopManager() { }

	// RVA: 0x1B0EB90 Offset: 0x1B0D590 VA: 0x181B0EB90
	public void ManageLeases(object state) { }

	// RVA: 0x1B0F2F0 Offset: 0x1B0DCF0 VA: 0x181B0F2F0
	public void .ctor() { }
}
