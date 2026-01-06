public class ServicePointManager // TypeDefIndex: 10079
{
	// Fields
	private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }

	// Methods

	// RVA: 0x25C2730 Offset: 0x25C1130 VA: 0x1825C2730
	private static void .cctor() { }

	// RVA: 0x25C2650 Offset: 0x25C1050 VA: 0x1825C2650
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x25C2840 Offset: 0x25C1240 VA: 0x1825C2840
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x25C2890 Offset: 0x25C1290 VA: 0x1825C2890
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x25C28E0 Offset: 0x25C12E0 VA: 0x1825C28E0
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x25C2930 Offset: 0x25C1330 VA: 0x1825C2930
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x25C2980 Offset: 0x25C1380 VA: 0x1825C2980
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x25C2A10 Offset: 0x25C1410 VA: 0x1825C2A10
	public static void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0x25C1DD0 Offset: 0x25C07D0 VA: 0x1825C1DD0
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x25C1A90 Offset: 0x25C0490 VA: 0x1825C1A90
	internal static void CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0x25C26A0 Offset: 0x25C10A0 VA: 0x1825C26A0
	internal static void RemoveServicePoint(ServicePoint sp) { }
}
