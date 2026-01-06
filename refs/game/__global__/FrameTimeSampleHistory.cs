internal class FrameTimeSampleHistory // TypeDefIndex: 13687
{
	// Fields
	private List<FrameTimeSample> m_Samples; // 0x10
	internal FrameTimeSample SampleAverage; // 0x18
	internal FrameTimeSample SampleMin; // 0x30
	internal FrameTimeSample SampleMax; // 0x48
	private static Func<float, float, float> s_SampleValueAdd; // 0x0
	private static Func<float, float, float> s_SampleValueMin; // 0x8
	private static Func<float, float, float> s_SampleValueMax; // 0x10
	private static Func<float, float, float> s_SampleValueCountValid; // 0x18
	private static Func<float, float, float> s_SampleValueEnsureValid; // 0x20
	private static Func<float, float, float> s_SampleValueDivide; // 0x28

	// Methods

	// RVA: 0x29FF1C0 Offset: 0x29FDBC0 VA: 0x1829FF1C0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x29FE320 Offset: 0x29FCD20 VA: 0x1829FE320
	internal void Add(FrameTimeSample sample) { }

	// RVA: 0x29FE440 Offset: 0x29FCE40 VA: 0x1829FE440
	internal void ComputeAggregateValues() { }

	// RVA: 0x29FED40 Offset: 0x29FD740 VA: 0x1829FED40
	internal void DiscardOldSamples(int sampleHistorySize) { }

	// RVA: 0x29FE3F0 Offset: 0x29FCDF0 VA: 0x1829FE3F0
	internal void Clear() { }

	// RVA: 0x29FEED0 Offset: 0x29FD8D0 VA: 0x1829FEED0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x29FEDE0 Offset: 0x29FD7E0 VA: 0x1829FEDE0
	internal static void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref FrameTimeSample aggregate, FrameTimeSample sample, Func<float, float, float> func) { }
}
