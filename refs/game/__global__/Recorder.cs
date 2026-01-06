public sealed class Recorder // TypeDefIndex: 11905
{
	// Fields
	private const ProfilerRecorderOptions s_RecorderDefaultOptions = 153;
	internal static Recorder s_InvalidRecorder; // 0x0
	private ProfilerRecorder m_RecorderCPU; // 0x10
	private ProfilerRecorder m_RecorderGPU; // 0x18

	// Properties
	public bool enabled { get; set; }
	public long elapsedNanoseconds { get; }
	public long gpuElapsedNanoseconds { get; }
	public int sampleBlockCount { get; }
	public int gpuSampleBlockCount { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x2CC46F0 Offset: 0x2CC30F0 VA: 0x182CC46F0
	internal void .ctor(ProfilerRecorderHandle handle) { }

	// RVA: 0x2CC45A0 Offset: 0x2CC2FA0 VA: 0x182CC45A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2CC47E0 Offset: 0x2CC31E0 VA: 0x182CC47E0
	public bool get_enabled() { }

	// RVA: 0x2CC4610 Offset: 0x2CC3010 VA: 0x182CC4610
	public void set_enabled(bool value) { }

	// RVA: 0x2CC47B0 Offset: 0x2CC31B0 VA: 0x182CC47B0
	public long get_elapsedNanoseconds() { }

	// RVA: 0x2CC47F0 Offset: 0x2CC31F0 VA: 0x182CC47F0
	public long get_gpuElapsedNanoseconds() { }

	// RVA: 0x2CC4880 Offset: 0x2CC3280 VA: 0x182CC4880
	public int get_sampleBlockCount() { }

	// RVA: 0x2CC4820 Offset: 0x2CC3220 VA: 0x182CC4820
	public int get_gpuSampleBlockCount() { }

	// RVA: 0x2CC4610 Offset: 0x2CC3010 VA: 0x182CC4610
	private void SetEnabled(bool state) { }

	// RVA: 0x2CC4680 Offset: 0x2CC3080 VA: 0x182CC4680
	private static void .cctor() { }
}
