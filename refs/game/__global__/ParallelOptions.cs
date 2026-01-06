public class ParallelOptions // TypeDefIndex: 4021
{
	// Fields
	private TaskScheduler _scheduler; // 0x10
	private int _maxDegreeOfParallelism; // 0x18
	private CancellationToken _cancellationToken; // 0x20

	// Properties
	public TaskScheduler TaskScheduler { get; }
	internal TaskScheduler EffectiveTaskScheduler { get; }
	public int MaxDegreeOfParallelism { get; set; }
	public CancellationToken CancellationToken { get; }
	internal int EffectiveMaxConcurrencyLevel { get; }

	// Methods

	// RVA: 0x1CF2260 Offset: 0x1CF0C60 VA: 0x181CF2260
	public void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public TaskScheduler get_TaskScheduler() { }

	// RVA: 0x1CF2420 Offset: 0x1CF0E20 VA: 0x181CF2420
	internal TaskScheduler get_EffectiveTaskScheduler() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_MaxDegreeOfParallelism() { }

	// RVA: 0x1CF2480 Offset: 0x1CF0E80 VA: 0x181CF2480
	public void set_MaxDegreeOfParallelism(int value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x1CF2340 Offset: 0x1CF0D40 VA: 0x181CF2340
	internal int get_EffectiveMaxConcurrencyLevel() { }
}
