public class TimeMeasure : Ring<long> // TypeDefIndex: 10405
{
	// Fields
	public Stopwatch mWatch; // 0x20

	// Properties
	public double LastTicks { get; }
	public double LastMS { get; }
	public double AverageMS { get; }
	public double MinimumMS { get; }
	public double MaximumMS { get; }
	public double AverageTicks { get; }
	public double MinimumTicks { get; }
	public double MaximumTicks { get; }

	// Methods

	// RVA: 0x49E240 Offset: 0x49CC40 VA: 0x18049E240
	public void .ctor(int size) { }

	// RVA: 0x49E1A0 Offset: 0x49CBA0 VA: 0x18049E1A0
	public void Start() { }

	// RVA: 0x49E1C0 Offset: 0x49CBC0 VA: 0x18049E1C0
	public void Stop() { }

	// RVA: 0x49E180 Offset: 0x49CB80 VA: 0x18049E180
	public void Pause() { }

	// RVA: 0x49E510 Offset: 0x49CF10 VA: 0x18049E510
	public double get_LastTicks() { }

	// RVA: 0x49E4A0 Offset: 0x49CEA0 VA: 0x18049E4A0
	public double get_LastMS() { }

	// RVA: 0x49E2D0 Offset: 0x49CCD0 VA: 0x18049E2D0
	public double get_AverageMS() { }

	// RVA: 0x49E750 Offset: 0x49D150 VA: 0x18049E750
	public double get_MinimumMS() { }

	// RVA: 0x49E570 Offset: 0x49CF70 VA: 0x18049E570
	public double get_MaximumMS() { }

	// RVA: 0x49E3D0 Offset: 0x49CDD0 VA: 0x18049E3D0
	public double get_AverageTicks() { }

	// RVA: 0x49E870 Offset: 0x49D270 VA: 0x18049E870
	public double get_MinimumTicks() { }

	// RVA: 0x49E680 Offset: 0x49D080 VA: 0x18049E680
	public double get_MaximumTicks() { }
}
