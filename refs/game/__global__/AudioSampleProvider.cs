public class AudioSampleProvider // TypeDefIndex: 18959
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2C7C2D0 Offset: 0x2C7ACD0 VA: 0x182C7C2D0
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2C7C300 Offset: 0x2C7AD00 VA: 0x182C7C300
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}
