internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 11767
{
	// Methods

	// RVA: 0x2CC3080 Offset: 0x2CC1A80 VA: 0x182CC3080 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x2CC3190 Offset: 0x2CC1B90 VA: 0x182CC3190 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x2CC2EE0 Offset: 0x2CC18E0 VA: 0x182CC2EE0 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x2CC3010 Offset: 0x2CC1A10 VA: 0x182CC3010 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x2CC32A0 Offset: 0x2CC1CA0 VA: 0x182CC32A0 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x2CC2E80 Offset: 0x2CC1880 VA: 0x182CC2E80 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x2CC2EB0 Offset: 0x2CC18B0 VA: 0x182CC2EB0 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x2CC2E50 Offset: 0x2CC1850 VA: 0x182CC2E50 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	// RVA: 0x2CC2EB0 Offset: 0x2CC18B0 VA: 0x182CC2EB0
	private static bool IsConnected() { }

	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	// RVA: 0x2CC2E80 Offset: 0x2CC1880 VA: 0x182CC2E80
	private static void Initialize() { }

	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	// RVA: 0x2CC2F10 Offset: 0x2CC1910 VA: 0x182CC2F10
	private static void RegisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	// RVA: 0x2CC3310 Offset: 0x2CC1D10 VA: 0x182CC3310
	private static void UnregisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	// RVA: 0x2CC2F50 Offset: 0x2CC1950 VA: 0x182CC2F50
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	// RVA: 0x2CC2FB0 Offset: 0x2CC19B0 VA: 0x182CC2FB0
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	// RVA: 0x2CC2EE0 Offset: 0x2CC18E0 VA: 0x182CC2EE0
	private static void PollInternal() { }

	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	// RVA: 0x2CC2E50 Offset: 0x2CC1850 VA: 0x182CC2E50
	private static void DisconnectAll() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
