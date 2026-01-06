internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 9640
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract X509ChainElementCollection ChainElements { get; }
	public abstract X509ChainPolicy ChainPolicy { get; }
	public abstract X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x2656180 Offset: 0x2654B80 VA: 0x182656180
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509ChainElementCollection get_ChainElements();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract X509ChainPolicy get_ChainPolicy();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract X509ChainStatus[] get_ChainStatus();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Build(X509Certificate2 certificate);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AddStatus(X509ChainStatusFlags errorCode);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Reset();

	// RVA: 0x2656110 Offset: 0x2654B10 VA: 0x182656110 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1AF6810 Offset: 0x1AF5210 VA: 0x181AF6810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
