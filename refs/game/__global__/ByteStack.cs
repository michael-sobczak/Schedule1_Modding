internal class ByteStack // TypeDefIndex: 7910
{
	// Fields
	private byte[] stack; // 0x10
	private int growthRate; // 0x18
	private int top; // 0x1C
	private int size; // 0x20

	// Methods

	// RVA: 0x23AF3E0 Offset: 0x23ADDE0 VA: 0x1823AF3E0
	public void .ctor(int growthRate) { }

	// RVA: 0x23AF310 Offset: 0x23ADD10 VA: 0x1823AF310
	public void Push(byte data) { }

	// RVA: 0x23AF2C0 Offset: 0x23ADCC0 VA: 0x1823AF2C0
	public byte Pop() { }
}
