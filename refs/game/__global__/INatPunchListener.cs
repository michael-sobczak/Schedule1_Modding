public interface INatPunchListener // TypeDefIndex: 12387
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);
}
