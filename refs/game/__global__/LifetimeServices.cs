public sealed class LifetimeServices // TypeDefIndex: 4314
{
	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x1B10580 Offset: 0x1B0EF80 VA: 0x181B10580
	private static void .cctor() { }

	// RVA: 0x1B106F0 Offset: 0x1B0F0F0 VA: 0x181B106F0
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x1B10830 Offset: 0x1B0F230 VA: 0x181B10830
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x1B10740 Offset: 0x1B0F140 VA: 0x181B10740
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x1B108B0 Offset: 0x1B0F2B0 VA: 0x181B108B0
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x1B10790 Offset: 0x1B0F190 VA: 0x181B10790
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1B10910 Offset: 0x1B0F310 VA: 0x181B10910
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x1B107E0 Offset: 0x1B0F1E0 VA: 0x181B107E0
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x1B10970 Offset: 0x1B0F370 VA: 0x181B10970
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x1B10510 Offset: 0x1B0EF10 VA: 0x181B10510
	internal static void TrackLifetime(ServerIdentity identity) { }
}
