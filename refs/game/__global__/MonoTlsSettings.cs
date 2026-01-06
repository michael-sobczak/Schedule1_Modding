public sealed class MonoTlsSettings // TypeDefIndex: 17542
{
	// Fields
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGenerated]
	private string[] <ClientCertificateIssuers>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x5C
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x68
	private bool cloned; // 0x70
	private bool checkCertName; // 0x71
	private bool checkCertRevocationStatus; // 0x72
	private Nullable<bool> useServicePointManagerCallback; // 0x73
	private bool skipSystemValidators; // 0x75
	private bool callbackNeedsChain; // 0x76
	private ICertificateValidator certificateValidator; // 0x78
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public string[] ClientCertificateIssuers { get; set; }
	public bool DisallowUnauthenticatedCertificateRequest { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x1A7B070 Offset: 0x1A79A70 VA: 0x181A7B070
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x1A7B090 Offset: 0x1A79A90 VA: 0x181A7B090
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x1A7AFC0 Offset: 0x1A799C0 VA: 0x181A7AFC0
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGenerated]
	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGenerated]
	// RVA: 0x4976E0 Offset: 0x4960E0 VA: 0x1804976E0
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public object get_UserSettings() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_UserSettings(object value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	internal bool get_SendCloseNotify() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string[] get_ClientCertificateIssuers() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_ClientCertificateIssuers(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1A7B060 Offset: 0x1A79A60 VA: 0x181A7B060
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGenerated]
	// RVA: 0x1A7B080 Offset: 0x1A79A80 VA: 0x181A7B080
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x1A7AFB0 Offset: 0x1A799B0 VA: 0x181A7AFB0
	public void .ctor() { }

	// RVA: 0x1A7AFD0 Offset: 0x1A799D0 VA: 0x181A7AFD0
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x1A7AD40 Offset: 0x1A79740 VA: 0x181A7AD40
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public ICertificateValidator get_CertificateValidator() { }

	[Obsolete("Do not use outside System.dll!")]
	// RVA: 0x1A7AC40 Offset: 0x1A79640 VA: 0x181A7AC40
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1A7ACE0 Offset: 0x1A796E0 VA: 0x181A7ACE0
	public MonoTlsSettings Clone() { }

	// RVA: 0x1A7AE20 Offset: 0x1A79820 VA: 0x181A7AE20
	private void .ctor(MonoTlsSettings other) { }
}
