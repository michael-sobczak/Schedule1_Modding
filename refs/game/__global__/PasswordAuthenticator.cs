public class PasswordAuthenticator : HostAuthenticator // TypeDefIndex: 18116
{
	// Fields
	[CompilerGenerated]
	private Action<NetworkConnection, bool> OnAuthenticationResult; // 0x38
	[Tooltip("Password to authenticate.")]
	[SerializeField]
	private string _password; // 0x40

	// Methods

	[CompilerGenerated]
	// RVA: 0xCE9DC0 Offset: 0xCE87C0 VA: 0x180CE9DC0 Slot: 4
	public override void add_OnAuthenticationResult(Action<NetworkConnection, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCE9E70 Offset: 0xCE8870 VA: 0x180CE9E70 Slot: 5
	public override void remove_OnAuthenticationResult(Action<NetworkConnection, bool> value) { }

	// RVA: 0xCE9900 Offset: 0xCE8300 VA: 0x180CE9900 Slot: 6
	public override void InitializeOnce(NetworkManager networkManager) { }

	// RVA: 0xCE9790 Offset: 0xCE8190 VA: 0x180CE9790
	private void ClientManager_OnClientConnectionState(ClientConnectionStateArgs args) { }

	// RVA: 0xCE9BD0 Offset: 0xCE85D0 VA: 0x180CE9BD0
	private void OnPasswordBroadcast(NetworkConnection conn, PasswordBroadcast pb) { }

	// RVA: 0xCE9C60 Offset: 0xCE8660 VA: 0x180CE9C60
	private void OnResponseBroadcast(ResponseBroadcast rb) { }

	// RVA: 0xCE9CD0 Offset: 0xCE86D0 VA: 0x180CE9CD0
	private void SendAuthenticationResponse(NetworkConnection conn, bool authenticated) { }

	// RVA: 0xCE9B80 Offset: 0xCE8580 VA: 0x180CE9B80 Slot: 8
	protected override void OnHostAuthenticationResult(NetworkConnection conn, bool authenticated) { }

	// RVA: 0xCE9D50 Offset: 0xCE8750 VA: 0x180CE9D50
	public void .ctor() { }
}
