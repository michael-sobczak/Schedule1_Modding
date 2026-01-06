public abstract class Authenticator : MonoBehaviour // TypeDefIndex: 12832
{
	// Fields
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x20
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x28

	// Properties
	public bool Initialized { get; set; }
	protected NetworkManager NetworkManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	protected NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_NetworkManager(NetworkManager value) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_OnAuthenticationResult(Action<NetworkConnection, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_OnAuthenticationResult(Action<NetworkConnection, bool> value);

	// RVA: 0xD908A0 Offset: 0xD8F2A0 VA: 0x180D908A0 Slot: 6
	public virtual void InitializeOnce(NetworkManager networkManager) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void OnRemoteConnection(NetworkConnection connection) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
