public abstract class HostAuthenticator : Authenticator // TypeDefIndex: 18081
{
	// Fields
	[SerializeField]
	[Tooltip("True to enable use of AuthenticateAsHost.")]
	private bool _allowHostAuthentication; // 0x30
	private static string _hostHash; // 0x0

	// Methods

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void SetAllowHostAuthentication(bool value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool GetAllowHostAuthentication() { }

	// RVA: 0xCE6F10 Offset: 0xCE5910 VA: 0x180CE6F10 Slot: 6
	public override void InitializeOnce(NetworkManager networkManager) { }

	// RVA: 0xCE7100 Offset: 0xCE5B00 VA: 0x180CE7100
	private void ServerManager_OnServerConnectionState(ServerConnectionStateArgs obj) { }

	// RVA: 0xCE7030 Offset: 0xCE5A30 VA: 0x180CE7030
	private void OnHostPasswordBroadcast(NetworkConnection conn, HostPasswordBroadcast hpb) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnHostAuthenticationResult(NetworkConnection conn, bool authenticated);

	// RVA: 0xCE7120 Offset: 0xCE5B20 VA: 0x180CE7120
	private void SetHostHash(int length) { }

	// RVA: 0xCE6E10 Offset: 0xCE5810 VA: 0x180CE6E10
	protected bool AuthenticateAsHost() { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	protected void .ctor() { }

	// RVA: 0xCE7380 Offset: 0xCE5D80 VA: 0x180CE7380
	private static void .cctor() { }
}
