public sealed class AudioClip : Object // TypeDefIndex: 18954
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativeProperty("LengthSec")]
	public float length { get; }
	[NativeProperty("SampleCount")]
	public int samples { get; }
	public int frequency { get; }

	// Methods

	// RVA: 0x2C7AF40 Offset: 0x2C79940 VA: 0x182C7AF40
	private void .ctor() { }

	// RVA: 0x2C7AFF0 Offset: 0x2C799F0 VA: 0x182C7AFF0
	public float get_length() { }

	// RVA: 0x2C7B030 Offset: 0x2C79A30 VA: 0x182C7B030
	public int get_samples() { }

	// RVA: 0x2C7AFB0 Offset: 0x2C799B0 VA: 0x182C7AFB0
	public int get_frequency() { }

	[RequiredByNativeCode]
	// RVA: 0x2C7AF00 Offset: 0x2C79900 VA: 0x182C7AF00
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	// RVA: 0x2C7AF20 Offset: 0x2C79920 VA: 0x182C7AF20
	private void InvokePCMSetPositionCallback_Internal(int position) { }
}
