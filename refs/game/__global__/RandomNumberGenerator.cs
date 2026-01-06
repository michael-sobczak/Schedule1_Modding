public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 4210
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1AEC270 Offset: 0x1AEAC70 VA: 0x181AEC270
	public static RandomNumberGenerator Create() { }

	// RVA: 0x1AEC2C0 Offset: 0x1AEACC0 VA: 0x181AEC2C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);
}
