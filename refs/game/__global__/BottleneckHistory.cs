internal class BottleneckHistory // TypeDefIndex: 13684
{
	// Fields
	private List<PerformanceBottleneck> m_Bottlenecks; // 0x10
	internal BottleneckHistogram Histogram; // 0x18

	// Methods

	// RVA: 0x29FC890 Offset: 0x29FB290 VA: 0x1829FC890
	public void .ctor(int initialCapacity) { }

	// RVA: 0x29FC7F0 Offset: 0x29FB1F0 VA: 0x1829FC7F0
	internal void DiscardOldSamples(int historySize) { }

	// RVA: 0x29FC410 Offset: 0x29FAE10 VA: 0x1829FC410
	internal void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage) { }

	// RVA: 0x29FC5A0 Offset: 0x29FAFA0 VA: 0x1829FC5A0
	internal void ComputeHistogram() { }

	// RVA: 0x29FC720 Offset: 0x29FB120 VA: 0x1829FC720
	private static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s) { }

	// RVA: 0x29FC550 Offset: 0x29FAF50 VA: 0x1829FC550
	internal void Clear() { }
}
