public class EventBasedNatPunchListener : INatPunchListener // TypeDefIndex: 12390
{
	// Fields
	[CompilerGenerated]
	private EventBasedNatPunchListener.OnNatIntroductionRequest NatIntroductionRequest; // 0x10
	[CompilerGenerated]
	private EventBasedNatPunchListener.OnNatIntroductionSuccess NatIntroductionSuccess; // 0x18

	// Methods

	[CompilerGenerated]
	// RVA: 0xCF1D40 Offset: 0xCF0740 VA: 0x180CF1D40
	public void add_NatIntroductionRequest(EventBasedNatPunchListener.OnNatIntroductionRequest value) { }

	[CompilerGenerated]
	// RVA: 0xCF1E80 Offset: 0xCF0880 VA: 0x180CF1E80
	public void remove_NatIntroductionRequest(EventBasedNatPunchListener.OnNatIntroductionRequest value) { }

	[CompilerGenerated]
	// RVA: 0xCF1DE0 Offset: 0xCF07E0 VA: 0x180CF1DE0
	public void add_NatIntroductionSuccess(EventBasedNatPunchListener.OnNatIntroductionSuccess value) { }

	[CompilerGenerated]
	// RVA: 0xCF1F20 Offset: 0xCF0920 VA: 0x180CF1F20
	public void remove_NatIntroductionSuccess(EventBasedNatPunchListener.OnNatIntroductionSuccess value) { }

	// RVA: 0xCF1D00 Offset: 0xCF0700 VA: 0x180CF1D00 Slot: 4
	private void LiteNetLib.INatPunchListener.OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token) { }

	// RVA: 0xCF1D20 Offset: 0xCF0720 VA: 0x180CF1D20 Slot: 5
	private void LiteNetLib.INatPunchListener.OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
