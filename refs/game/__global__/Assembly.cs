public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 4745
{
	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	internal virtual IntPtr MonoAssembly { get; }
	public virtual string Location { get; }
	[ComVisible(False)]
	public virtual bool ReflectionOnly { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x1B7F7F0 Offset: 0x1B7E1F0 VA: 0x181B7F7F0 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0x1B7F830 Offset: 0x1B7E230 VA: 0x181B7F830 Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x1B7F8B0 Offset: 0x1B7E2B0 VA: 0x181B7F8B0 Slot: 10
	internal virtual IntPtr get_MonoAssembly() { }

	// RVA: 0x1B7F870 Offset: 0x1B7E270 VA: 0x181B7F870 Slot: 11
	public virtual string get_Location() { }

	// RVA: 0x1B7EDF0 Offset: 0x1B7D7F0 VA: 0x181B7EDF0 Slot: 12
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B7F5C0 Offset: 0x1B7DFC0 VA: 0x181B7F5C0 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B7E840 Offset: 0x1B7D240 VA: 0x181B7E840 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B7E800 Offset: 0x1B7D200 VA: 0x181B7E800 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B7E960 Offset: 0x1B7D360 VA: 0x181B7E960 Slot: 16
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x1B7EC90 Offset: 0x1B7D690 VA: 0x181B7EC90 Slot: 17
	public virtual Stream GetManifestResourceStream(Type type, string name) { }

	// RVA: 0x1B7EAD0 Offset: 0x1B7D4D0 VA: 0x181B7EAD0
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B7E9A0 Offset: 0x1B7D3A0 VA: 0x181B7E9A0
	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	// RVA: 0x1B7F0C0 Offset: 0x1B7DAC0 VA: 0x181B7F0C0
	internal string GetSimpleName() { }

	// RVA: 0x1B7EE30 Offset: 0x1B7D830 VA: 0x181B7EE30
	internal byte[] GetPublicKey() { }

	// RVA: 0x1B7F1B0 Offset: 0x1B7DBB0 VA: 0x181B7F1B0
	internal Version GetVersion() { }

	// RVA: 0x1B7E8B0 Offset: 0x1B7D2B0 VA: 0x181B7E8B0
	private AssemblyNameFlags GetFlags() { }

	// RVA: 0x1B7F180 Offset: 0x1B7DB80 VA: 0x181B7F180 Slot: 18
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x1B7F190 Offset: 0x1B7DB90 VA: 0x181B7F190 Slot: 19
	public virtual Type[] GetTypes() { }

	// RVA: 0x1B7F120 Offset: 0x1B7DB20 VA: 0x181B7F120 Slot: 20
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x1B7F0F0 Offset: 0x1B7DAF0 VA: 0x181B7F0F0 Slot: 21
	public virtual Type GetType(string name) { }

	// RVA: 0x1B7F5B0 Offset: 0x1B7DFB0 VA: 0x181B7F5B0
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1B7ED90 Offset: 0x1B7D790 VA: 0x181B7ED90 Slot: 22
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x1B7EDD0 Offset: 0x1B7D7D0 VA: 0x181B7EDD0 Slot: 23
	public virtual AssemblyName GetName() { }

	// RVA: 0x1B7F7E0 Offset: 0x1B7E1E0 VA: 0x181B7F7E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B7E730 Offset: 0x1B7D130 VA: 0x181B7E730
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x1B7F1F0 Offset: 0x1B7DBF0 VA: 0x181B7F1F0
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B7F600 Offset: 0x1B7E000 VA: 0x181B7F600
	private static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B7F760 Offset: 0x1B7E160 VA: 0x181B7F760
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x1B7F790 Offset: 0x1B7E190 VA: 0x181B7F790
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1B7F610 Offset: 0x1B7E010 VA: 0x181B7F610
	public static Assembly LoadWithPartialName(string partialName) { }

	// RVA: 0x1B7F930 Offset: 0x1B7E330 VA: 0x181B7F930
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1B7F700 Offset: 0x1B7E100 VA: 0x181B7F700
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x1B7F670 Offset: 0x1B7E070 VA: 0x181B7F670
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x1B7E5B0 Offset: 0x1B7CFB0 VA: 0x181B7E5B0 Slot: 24
	public object CreateInstance(string typeName) { }

	// RVA: 0x1B7E5C0 Offset: 0x1B7CFC0 VA: 0x181B7E5C0 Slot: 25
	public object CreateInstance(string typeName, bool ignoreCase) { }

	// RVA: 0x1B7ED70 Offset: 0x1B7D770 VA: 0x181B7ED70 Slot: 26
	public Module[] GetModules() { }

	// RVA: 0x1B7ED00 Offset: 0x1B7D700 VA: 0x181B7ED00 Slot: 27
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x1B7E880 Offset: 0x1B7D280 VA: 0x181B7E880
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x1B7E7F0 Offset: 0x1B7D1F0 VA: 0x181B7E7F0
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x1B7F1E0 Offset: 0x1B7DBE0 VA: 0x181B7F1E0
	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	// RVA: 0x1B7E920 Offset: 0x1B7D320 VA: 0x181B7E920 Slot: 28
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x1B7EE60 Offset: 0x1B7D860 VA: 0x181B7EE60
	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	// RVA: 0x1B7E8E0 Offset: 0x1B7D2E0 VA: 0x181B7E8E0 Slot: 29
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x1B7F8F0 Offset: 0x1B7E2F0 VA: 0x181B7F8F0 Slot: 30
	public virtual bool get_ReflectionOnly() { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1B7E6D0 Offset: 0x1B7D0D0 VA: 0x181B7E6D0
	private static Exception CreateNIE() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool get_IsFullyTrusted() { }

	// RVA: 0x1B7F150 Offset: 0x1B7DB50 VA: 0x181B7F150 Slot: 31
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1B7ECD0 Offset: 0x1B7D6D0 VA: 0x181B7ECD0 Slot: 32
	public virtual Module GetModule(string name) { }

	// RVA: 0x1B7F090 Offset: 0x1B7DA90 VA: 0x181B7F090 Slot: 33
	public virtual AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x1B7ED40 Offset: 0x1B7D740 VA: 0x181B7ED40 Slot: 34
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x1B7F940 Offset: 0x1B7E340 VA: 0x181B7F940
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x1B7F9A0 Offset: 0x1B7E3A0 VA: 0x181B7F9A0
	public static bool op_Inequality(Assembly left, Assembly right) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
