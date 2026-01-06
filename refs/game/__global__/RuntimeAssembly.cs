internal class RuntimeAssembly : Assembly // TypeDefIndex: 4752
{
	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private object _evidence; // 0x18
	internal Assembly.ResolveEventHolder resolve_event_holder; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	internal bool fromByteArray; // 0x50
	internal string assemblyName; // 0x58

	// Properties
	[ComVisible(False)]
	public override bool ReflectionOnly { get; }
	public override string CodeBase { get; }
	public override string FullName { get; }
	internal override IntPtr MonoAssembly { get; }
	public override string Location { get; }

	// Methods

	// RVA: 0x1B919A0 Offset: 0x1B903A0 VA: 0x181B919A0
	protected void .ctor() { }

	// RVA: 0x1B915B0 Offset: 0x1B8FFB0 VA: 0x181B915B0 Slot: 12
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B91890 Offset: 0x1B90290 VA: 0x181B91890
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B917A0 Offset: 0x1B901A0 VA: 0x181B917A0
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B914E0 Offset: 0x1B8FEE0 VA: 0x181B914E0 Slot: 22
	public override AssemblyName GetName(bool copiedName) { }

	// RVA: 0x1B91660 Offset: 0x1B90060 VA: 0x181B91660 Slot: 31
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1B91220 Offset: 0x1B8FC20 VA: 0x181B91220 Slot: 32
	public override Module GetModule(string name) { }

	// RVA: 0x1B91650 Offset: 0x1B90050 VA: 0x181B91650 Slot: 33
	public override AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x1B913A0 Offset: 0x1B8FDA0 VA: 0x181B913A0 Slot: 34
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x1B90BA0 Offset: 0x1B8F5A0 VA: 0x181B90BA0
	internal static byte[] GetAotId() { }

	// RVA: 0x1B90BF0 Offset: 0x1B8F5F0 VA: 0x181B90BF0
	private static string get_code_base(Assembly a, bool escaped) { }

	// RVA: 0x1B91A80 Offset: 0x1B90480 VA: 0x181B91A80
	private string get_location() { }

	// RVA: 0x1B91A20 Offset: 0x1B90420 VA: 0x181B91A20
	internal static string get_fullname(Assembly a) { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	internal static bool GetAotIdInternal(byte[] aotid) { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80 Slot: 30
	public override bool get_ReflectionOnly() { }

	// RVA: 0x1B90BF0 Offset: 0x1B8F5F0 VA: 0x181B90BF0
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	// RVA: 0x1B91A10 Offset: 0x1B90410 VA: 0x181B91A10 Slot: 8
	public override string get_CodeBase() { }

	// RVA: 0x1B91A20 Offset: 0x1B90420 VA: 0x181B91A20 Slot: 9
	public override string get_FullName() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 10
	internal override IntPtr get_MonoAssembly() { }

	// RVA: 0x1B91A30 Offset: 0x1B90430 VA: 0x181B91A30 Slot: 11
	public override string get_Location() { }

	// RVA: 0x1B90CD0 Offset: 0x1B8F6D0 VA: 0x181B90CD0
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x1B90CE0 Offset: 0x1B8F6E0 VA: 0x181B90CE0 Slot: 29
	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x1B90E30 Offset: 0x1B8F830 VA: 0x181B90E30 Slot: 28
	public override string[] GetManifestResourceNames() { }

	// RVA: 0x1B90E20 Offset: 0x1B8F820 VA: 0x181B90E20
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x1B90E40 Offset: 0x1B8F840 VA: 0x181B90E40 Slot: 16
	public override Stream GetManifestResourceStream(string name) { }

	// RVA: 0x1B7EAD0 Offset: 0x1B7D4D0 VA: 0x181B7EAD0 Slot: 17
	public override Stream GetManifestResourceStream(Type type, string name) { }

	// RVA: 0x1B91730 Offset: 0x1B90130 VA: 0x181B91730 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B90C00 Offset: 0x1B8F600 VA: 0x181B90C00 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B90C60 Offset: 0x1B8F660 VA: 0x181B90C60 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B91390 Offset: 0x1B8FD90 VA: 0x181B91390 Slot: 27
	internal override Module[] GetModulesInternal() { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B90AE0 Offset: 0x1B8F4E0 VA: 0x181B90AE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1B91950 Offset: 0x1B90350 VA: 0x181B91950 Slot: 3
	public override string ToString() { }
}
