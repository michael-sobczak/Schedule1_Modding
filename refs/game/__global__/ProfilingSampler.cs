public class ProfilingSampler // TypeDefIndex: 13697
{
	// Fields
	[CompilerGenerated]
	private CustomSampler <sampler>k__BackingField; // 0x10
	[CompilerGenerated]
	private CustomSampler <inlineSampler>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x20
	private Recorder m_Recorder; // 0x28
	private Recorder m_InlineRecorder; // 0x30

	// Properties
	internal CustomSampler sampler { get; set; }
	internal CustomSampler inlineSampler { get; set; }
	public string name { get; set; }
	public bool enableRecording { set; }
	public float gpuElapsedTime { get; }
	public int gpuSampleCount { get; }
	public float cpuElapsedTime { get; }
	public int cpuSampleCount { get; }
	public float inlineCpuElapsedTime { get; }
	public int inlineCpuSampleCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ProfilingSampler Get<TEnum>(TEnum marker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF27CB0 Offset: 0xF266B0 VA: 0x180F27CB0
	|-ProfilingSampler.Get<Int32Enum>
	|
	|-RVA: 0xF27B90 Offset: 0xF26590 VA: 0x180F27B90
	|-ProfilingSampler.Get<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2A12F80 Offset: 0x2A11980 VA: 0x182A12F80
	public void .ctor(string name) { }

	// RVA: 0x2A12EA0 Offset: 0x2A118A0 VA: 0x182A12EA0
	public void Begin(CommandBuffer cmd) { }

	// RVA: 0x2A12F00 Offset: 0x2A11900 VA: 0x182A12F00
	public void End(CommandBuffer cmd) { }

	// RVA: 0x2A12F60 Offset: 0x2A11960 VA: 0x182A12F60
	internal bool IsValid() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal CustomSampler get_sampler() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_sampler(CustomSampler value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal CustomSampler get_inlineSampler() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_inlineSampler(CustomSampler value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_name(string value) { }

	// RVA: 0x2A13290 Offset: 0x2A11C90 VA: 0x182A13290
	public void set_enableRecording(bool value) { }

	// RVA: 0x2A13150 Offset: 0x2A11B50 VA: 0x182A13150
	public float get_gpuElapsedTime() { }

	// RVA: 0x2A131B0 Offset: 0x2A11BB0 VA: 0x182A131B0
	public int get_gpuSampleCount() { }

	// RVA: 0x2A130B0 Offset: 0x2A11AB0 VA: 0x182A130B0
	public float get_cpuElapsedTime() { }

	// RVA: 0x2A13110 Offset: 0x2A11B10 VA: 0x182A13110
	public int get_cpuSampleCount() { }

	// RVA: 0x2A131F0 Offset: 0x2A11BF0 VA: 0x182A131F0
	public float get_inlineCpuElapsedTime() { }

	// RVA: 0x2A13250 Offset: 0x2A11C50 VA: 0x182A13250
	public int get_inlineCpuSampleCount() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }
}
