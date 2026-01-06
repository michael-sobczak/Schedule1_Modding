public struct HapticState // TypeDefIndex: 7479
{
	// Fields
	[CompilerGenerated]
	private uint <samplesQueued>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <samplesAvailable>k__BackingField; // 0x4

	// Properties
	public uint samplesQueued { get; set; }
	public uint samplesAvailable { get; set; }

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(uint samplesQueued, uint samplesAvailable) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public uint get_samplesQueued() { }

	[CompilerGenerated]
	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	private void set_samplesQueued(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public uint get_samplesAvailable() { }

	[CompilerGenerated]
	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	private void set_samplesAvailable(uint value) { }
}
