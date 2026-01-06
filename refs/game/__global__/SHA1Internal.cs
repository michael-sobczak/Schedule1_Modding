internal class SHA1Internal // TypeDefIndex: 4249
{
	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x1AFB560 Offset: 0x1AF9F60 VA: 0x181AFB560
	public void .ctor() { }

	// RVA: 0x1AFA160 Offset: 0x1AF8B60 VA: 0x181AFA160
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1AFA2A0 Offset: 0x1AF8CA0 VA: 0x181AFA2A0
	public byte[] HashFinal() { }

	// RVA: 0x1AFAB10 Offset: 0x1AF9510 VA: 0x181AFAB10
	public void Initialize() { }

	// RVA: 0x1AFABA0 Offset: 0x1AF95A0 VA: 0x181AFABA0
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x1AFA390 Offset: 0x1AF8D90 VA: 0x181AFA390
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x1AF9E30 Offset: 0x1AF8830 VA: 0x181AF9E30
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x1AFB310 Offset: 0x1AF9D10 VA: 0x181AFB310
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1AF9D50 Offset: 0x1AF8750 VA: 0x181AF9D50
	internal void AddLength(ulong length, byte[] buffer, int position) { }
}
