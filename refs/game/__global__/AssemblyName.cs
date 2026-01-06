public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 4746
{
	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; set; }
	public string CodeBase { get; }
	public CultureInfo CultureInfo { get; set; }
	public AssemblyNameFlags Flags { get; set; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0xA7BC80 Offset: 0xA7A680 VA: 0x180A7BC80
	public void .ctor() { }

	// RVA: 0x1B7D800 Offset: 0x1B7C200 VA: 0x181B7D800
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x1B7D870 Offset: 0x1B7C270 VA: 0x181B7D870
	public void .ctor(string assemblyName) { }

	// RVA: 0x1B7DAC0 Offset: 0x1B7C4C0 VA: 0x181B7DAC0
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_CodeBase() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_CultureInfo(CultureInfo value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_Flags(AssemblyNameFlags value) { }

	// RVA: 0x1B7E050 Offset: 0x1B7CA50 VA: 0x181B7E050
	public string get_FullName() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Version get_Version() { }

	// RVA: 0x1B7E530 Offset: 0x1B7CF30 VA: 0x181B7E530
	public void set_Version(Version value) { }

	// RVA: 0x1B7D840 Offset: 0x1B7C240 VA: 0x181B7D840 Slot: 3
	public override string ToString() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public byte[] GetPublicKey() { }

	// RVA: 0x1B7D5A0 Offset: 0x1B7BFA0 VA: 0x181B7D5A0
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x1B7E460 Offset: 0x1B7CE60 VA: 0x181B7E460
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x1B7D690 Offset: 0x1B7C090 VA: 0x181B7D690
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0x1B7E520 Offset: 0x1B7CF20 VA: 0x181B7E520
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x1B7CE50 Offset: 0x1B7B850 VA: 0x181B7CE50
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x1B7D810 Offset: 0x1B7C210 VA: 0x181B7D810
	public void SetPublicKey(byte[] publicKey) { }

	// RVA: 0x1B7D2D0 Offset: 0x1B7BCD0 VA: 0x181B7D2D0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B7CD50 Offset: 0x1B7B750 VA: 0x181B7CD50 Slot: 4
	public object Clone() { }

	// RVA: 0x1B7D780 Offset: 0x1B7C180 VA: 0x181B7D780 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x1B7D2C0 Offset: 0x1B7BCC0 VA: 0x181B7D2C0
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x1B7CFE0 Offset: 0x1B7B9E0 VA: 0x181B7CFE0
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x1B7CEF0 Offset: 0x1B7B8F0 VA: 0x181B7CEF0
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }
}
