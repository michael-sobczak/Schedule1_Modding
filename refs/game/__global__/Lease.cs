internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 4310
{
	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x1B10340 Offset: 0x1B0ED40 VA: 0x181B10340
	public void .ctor() { }

	// RVA: 0x1B104B0 Offset: 0x1B0EEB0 VA: 0x181B104B0 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x1B0F610 Offset: 0x1B0E010 VA: 0x181B0F610
	public void Activate() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1B0FF70 Offset: 0x1B0E970 VA: 0x181B0FF70 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x1B10040 Offset: 0x1B0EA40 VA: 0x181B10040 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x1B10190 Offset: 0x1B0EB90 VA: 0x181B10190
	internal void UpdateState() { }

	// RVA: 0x1B0F620 Offset: 0x1B0E020 VA: 0x181B0F620
	private void CheckNextSponsor() { }

	// RVA: 0x1B0F9D0 Offset: 0x1B0E3D0 VA: 0x181B0F9D0
	private void ProcessSponsorResponse(object state, bool timedOut) { }
}
