public sealed class FSteamNetworkingSocketsDebugOutput : MulticastDelegate // TypeDefIndex: 14789
{
	// Methods

	// RVA: 0x825A40 Offset: 0x824440 VA: 0x180825A40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0 Slot: 13
	public virtual void Invoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg) { }

	// RVA: 0xC818B0 Offset: 0xC802B0 VA: 0x180C818B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
