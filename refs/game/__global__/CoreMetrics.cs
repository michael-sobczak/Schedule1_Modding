internal class CoreMetrics // TypeDefIndex: 17873
{
	// Fields
	internal const string PackageInitTimeMetricName = "package_init_time";
	internal const string AllPackagesInitSuccessMetricName = "all_packages_init_success";
	internal const string AllPackagesInitTimeMetricName = "all_packages_init_time";
	internal const string PackageInitializerNamesKeyFormat = "{0}.initializer-assembly-qualified-names";
	internal const char PackageInitializerNamesSeparator = '\x3b';
	internal const string AllPackageNamesKey = "com.unity.services.core.all-package-names";
	internal const char AllPackageNamesSeparator = '\x3b';
	[CompilerGenerated]
	private static CoreMetrics <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private IMetrics <Metrics>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IDictionary<Type, IMetrics> <AllPackageMetrics>k__BackingField; // 0x18

	// Properties
	public static CoreMetrics Instance { get; set; }
	internal IMetrics Metrics { get; set; }
	internal IDictionary<Type, IMetrics> AllPackageMetrics { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2B9BC60 Offset: 0x2B9A660 VA: 0x182B9BC60
	public static CoreMetrics get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x2B9BCA0 Offset: 0x2B9A6A0 VA: 0x182B9BCA0
	internal static void set_Instance(CoreMetrics value) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal IMetrics get_Metrics() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Metrics(IMetrics value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IDictionary<Type, IMetrics> get_AllPackageMetrics() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SendAllPackagesInitSuccessMetric() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SendAllPackagesInitTimeMetric(double initTimeSeconds) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SendInitTimeMetricForPackage(Type packageType, double initTimeSeconds) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Initialize(IProjectConfiguration configuration, IMetricsFactory factory, Type corePackageType) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void FindAndCacheAllPackageMetrics(IProjectConfiguration configuration, IMetricsFactory factory) { }

	// RVA: 0x2B9BBE0 Offset: 0x2B9A5E0 VA: 0x182B9BBE0
	public void .ctor() { }
}
