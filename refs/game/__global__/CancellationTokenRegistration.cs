public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 3939
{
	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x1330C10 Offset: 0x132F610 VA: 0x181330C10
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	// RVA: 0x1CD3400 Offset: 0x1CD1E00 VA: 0x181CD3400
	public bool Unregister() { }

	// RVA: 0x1CD3080 Offset: 0x1CD1A80 VA: 0x181CD3080 Slot: 5
	public void Dispose() { }

	// RVA: 0x1CD3260 Offset: 0x1CD1C60 VA: 0x181CD3260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1CD31D0 Offset: 0x1CD1BD0 VA: 0x181CD31D0 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x1CD3350 Offset: 0x1CD1D50 VA: 0x181CD3350 Slot: 2
	public override int GetHashCode() { }
}
