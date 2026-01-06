public class Stopwatch // TypeDefIndex: 9599
{
	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }
	public bool IsRunning { get; }

	// Methods

	// RVA: 0x1D04150 Offset: 0x1D02B50 VA: 0x181D04150
	public static long GetTimestamp() { }

	// RVA: 0x263C4B0 Offset: 0x263AEB0 VA: 0x18263C4B0
	public static Stopwatch StartNew() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x263C9E0 Offset: 0x263B3E0 VA: 0x18263C9E0
	public TimeSpan get_Elapsed() { }

	// RVA: 0x263C680 Offset: 0x263B080 VA: 0x18263C680
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x263C970 Offset: 0x263B370 VA: 0x18263C970
	public long get_ElapsedTicks() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsRunning() { }

	// RVA: 0x263C440 Offset: 0x263AE40 VA: 0x18263C440
	public void Reset() { }

	// RVA: 0x263C550 Offset: 0x263AF50 VA: 0x18263C550
	public void Start() { }

	// RVA: 0x263C5B0 Offset: 0x263AFB0 VA: 0x18263C5B0
	public void Stop() { }

	// RVA: 0x263C450 Offset: 0x263AE50 VA: 0x18263C450
	public void Restart() { }

	// RVA: 0x263C630 Offset: 0x263B030 VA: 0x18263C630
	private static void .cctor() { }
}
