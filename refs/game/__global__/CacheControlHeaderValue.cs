public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 17717
{
	// Fields
	private List<NameValueHeaderValue> extensions; // 0x10
	private List<string> no_cache_headers; // 0x18
	private List<string> private_headers; // 0x20
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxAge>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <MaxStale>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<TimeSpan> <MinFresh>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <MustRevalidate>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <NoCache>k__BackingField; // 0x61
	[CompilerGenerated]
	private bool <NoStore>k__BackingField; // 0x62
	[CompilerGenerated]
	private bool <NoTransform>k__BackingField; // 0x63
	[CompilerGenerated]
	private bool <OnlyIfCached>k__BackingField; // 0x64
	[CompilerGenerated]
	private bool <Private>k__BackingField; // 0x65
	[CompilerGenerated]
	private bool <ProxyRevalidate>k__BackingField; // 0x66
	[CompilerGenerated]
	private bool <Public>k__BackingField; // 0x67
	[CompilerGenerated]
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; // 0x68

	// Properties
	public ICollection<NameValueHeaderValue> Extensions { get; }
	public Nullable<TimeSpan> MaxAge { get; set; }
	public bool MaxStale { get; set; }
	public Nullable<TimeSpan> MaxStaleLimit { get; set; }
	public Nullable<TimeSpan> MinFresh { get; set; }
	public bool MustRevalidate { get; set; }
	public bool NoCache { get; set; }
	public ICollection<string> NoCacheHeaders { get; }
	public bool NoStore { get; set; }
	public bool NoTransform { get; set; }
	public bool OnlyIfCached { get; set; }
	public bool Private { get; set; }
	public ICollection<string> PrivateHeaders { get; }
	public bool ProxyRevalidate { get; set; }
	public bool Public { get; set; }
	public Nullable<TimeSpan> SharedMaxAge { get; set; }

	// Methods

	// RVA: 0x2180850 Offset: 0x217F250 VA: 0x182180850
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGenerated]
	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGenerated]
	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_MaxStale() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_MaxStale(bool value) { }

	[CompilerGenerated]
	// RVA: 0xAB8F60 Offset: 0xAB7960 VA: 0x180AB8F60
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGenerated]
	// RVA: 0xAB8F70 Offset: 0xAB7970 VA: 0x180AB8F70
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x84E920 Offset: 0x84D320 VA: 0x18084E920
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGenerated]
	// RVA: 0x84EA10 Offset: 0x84D410 VA: 0x18084EA10
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_MustRevalidate() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	public void set_MustRevalidate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340
	public bool get_NoCache() { }

	[CompilerGenerated]
	// RVA: 0x848350 Offset: 0x846D50 VA: 0x180848350
	public void set_NoCache(bool value) { }

	// RVA: 0x21808D0 Offset: 0x217F2D0 VA: 0x1821808D0
	public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGenerated]
	// RVA: 0xD7FDD0 Offset: 0xD7E7D0 VA: 0x180D7FDD0
	public bool get_NoStore() { }

	[CompilerGenerated]
	// RVA: 0x21809D0 Offset: 0x217F3D0 VA: 0x1821809D0
	public void set_NoStore(bool value) { }

	[CompilerGenerated]
	// RVA: 0xD7FDF0 Offset: 0xD7E7F0 VA: 0x180D7FDF0
	public bool get_NoTransform() { }

	[CompilerGenerated]
	// RVA: 0x21809E0 Offset: 0x217F3E0 VA: 0x1821809E0
	public void set_NoTransform(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E21A0 Offset: 0x4E0BA0 VA: 0x1804E21A0
	public bool get_OnlyIfCached() { }

	[CompilerGenerated]
	// RVA: 0x4E2830 Offset: 0x4E1230 VA: 0x1804E2830
	public void set_OnlyIfCached(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20902A0 Offset: 0x208ECA0 VA: 0x1820902A0
	public bool get_Private() { }

	[CompilerGenerated]
	// RVA: 0x21809F0 Offset: 0x217F3F0 VA: 0x1821809F0
	public void set_Private(bool value) { }

	// RVA: 0x2180950 Offset: 0x217F350 VA: 0x182180950
	public ICollection<string> get_PrivateHeaders() { }

	[CompilerGenerated]
	// RVA: 0x208F650 Offset: 0x208E050 VA: 0x18208F650
	public bool get_ProxyRevalidate() { }

	[CompilerGenerated]
	// RVA: 0x2180A00 Offset: 0x217F400 VA: 0x182180A00
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x208F640 Offset: 0x208E040 VA: 0x18208F640
	public bool get_Public() { }

	[CompilerGenerated]
	// RVA: 0x2180A10 Offset: 0x217F410 VA: 0x182180A10
	public void set_Public(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4F9E50 Offset: 0x4F8850 VA: 0x1804F9E50
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGenerated]
	// RVA: 0x2180A20 Offset: 0x217F420 VA: 0x182180A20
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	// RVA: 0x217EF80 Offset: 0x217D980 VA: 0x18217EF80 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x217EA50 Offset: 0x217D450 VA: 0x18217EA50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x217ED10 Offset: 0x217D710 VA: 0x18217ED10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217FC90 Offset: 0x217E690 VA: 0x18217FC90
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

	// RVA: 0x217F530 Offset: 0x217DF30 VA: 0x18217F530 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
