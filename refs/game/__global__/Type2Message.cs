public class Type2Message : MessageBase // TypeDefIndex: 17528
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x1A814E0 Offset: 0x1A7FEE0 VA: 0x181A814E0
	public void .ctor(byte[] message) { }

	// RVA: 0x1A813A0 Offset: 0x1A7FDA0 VA: 0x181A813A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A81590 Offset: 0x1A7FF90 VA: 0x181A81590
	public byte[] get_Nonce() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_TargetName() { }

	// RVA: 0x1A81610 Offset: 0x1A80010 VA: 0x181A81610
	public byte[] get_TargetInfo() { }

	// RVA: 0x1A81210 Offset: 0x1A7FC10 VA: 0x181A81210 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1A81410 Offset: 0x1A7FE10 VA: 0x181A81410 Slot: 5
	public override byte[] GetBytes() { }
}
