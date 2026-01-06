internal static class UnityTlsConversions // TypeDefIndex: 9378
{
	// Methods

	// RVA: 0x2024D80 Offset: 0x2023780 VA: 0x182024D80
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x2024D40 Offset: 0x2023740 VA: 0x182024D40
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x2024D10 Offset: 0x2023710 VA: 0x182024D10
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x2024DC0 Offset: 0x20237C0 VA: 0x182024DC0
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x2024E60 Offset: 0x2023860 VA: 0x182024E60
	public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

	// RVA: 0x2024E20 Offset: 0x2023820 VA: 0x182024E20
	public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult) { }
}
