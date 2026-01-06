public class MovingAverage : IDisposable // TypeDefIndex: 12816
{
	// Fields
	[CompilerGenerated]
	private float <Average>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <SampleSize>k__BackingField; // 0x14
	private int _writeIndex; // 0x18
	private float[] _samples; // 0x20
	private int _writtenSamples; // 0x28
	private float _sampleAccumulator; // 0x2C

	// Properties
	public float Average { get; set; }
	public int SampleSize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_Average() { }

	[CompilerGenerated]
	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	private void set_Average(float value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_SampleSize() { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	private void set_SampleSize(int value) { }

	// RVA: 0xD9BE40 Offset: 0xD9A840 VA: 0x180D9BE40
	public void .ctor(int sampleSize) { }

	// RVA: 0xD9BCF0 Offset: 0xD9A6F0 VA: 0x180D9BCF0
	public void ComputeAverage(float newSample) { }

	// RVA: 0xD9BE30 Offset: 0xD9A830 VA: 0x180D9BE30
	public void Reset() { }

	// RVA: 0xD9BE30 Offset: 0xD9A830 VA: 0x180D9BE30 Slot: 4
	public void Dispose() { }
}
