public struct HapticCapabilities // TypeDefIndex: 7481
{
	// Fields
	[CompilerGenerated]
	private readonly uint <numChannels>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <supportsImpulse>k__BackingField; // 0x4
	[CompilerGenerated]
	private readonly bool <supportsBuffer>k__BackingField; // 0x5
	[CompilerGenerated]
	private readonly uint <frequencyHz>k__BackingField; // 0x8
	[CompilerGenerated]
	private readonly uint <maxBufferSize>k__BackingField; // 0xC
	[CompilerGenerated]
	private readonly uint <optimalBufferSize>k__BackingField; // 0x10

	// Properties
	public uint numChannels { get; }
	public bool supportsImpulse { get; }
	public bool supportsBuffer { get; }
	public uint frequencyHz { get; }
	public uint maxBufferSize { get; }
	public uint optimalBufferSize { get; }

	// Methods

	// RVA: 0x2820100 Offset: 0x281EB00 VA: 0x182820100
	public void .ctor(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize) { }

	// RVA: 0x28200E0 Offset: 0x281EAE0 VA: 0x1828200E0
	public void .ctor(uint numChannels, uint frequencyHz, uint maxBufferSize) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public uint get_numChannels() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CD0 Offset: 0x4C16D0 VA: 0x1804C2CD0
	public bool get_supportsImpulse() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CE0 Offset: 0x4C16E0 VA: 0x1804C2CE0
	public bool get_supportsBuffer() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public uint get_frequencyHz() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public uint get_maxBufferSize() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public uint get_optimalBufferSize() { }
}
