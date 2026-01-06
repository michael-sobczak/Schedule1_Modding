public abstract class UxmlAttributeDescription // TypeDefIndex: 6959
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <name>k__BackingField; // 0x10
	private string[] m_ObsoleteNames; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <type>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <typeNamespace>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UxmlAttributeDescription.Use <use>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UxmlTypeRestriction <restriction>k__BackingField; // 0x38

	// Properties
	public string name { get; set; }
	public IEnumerable<string> obsoleteNames { set; }
	protected string type { set; }
	protected string typeNamespace { set; }
	public UxmlAttributeDescription.Use use { set; }
	public UxmlTypeRestriction restriction { set; }

	// Methods

	// RVA: 0x2DEC960 Offset: 0x2DEB360 VA: 0x182DEC960
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_name(string value) { }

	// RVA: 0x2DEC990 Offset: 0x2DEB390 VA: 0x182DEC990
	public void set_obsoleteNames(IEnumerable<string> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_type(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_typeNamespace(string value) { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_use(UxmlAttributeDescription.Use value) { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_restriction(UxmlTypeRestriction value) { }

	// RVA: 0x2DEC460 Offset: 0x2DEAE60 VA: 0x182DEC460
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value) { }

	// RVA: -1 Offset: -1
	protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF74510 Offset: 0xF72F10 VA: 0x180F74510
	|-UxmlAttributeDescription.TryGetValueFromBag<int>
	|-UxmlAttributeDescription.TryGetValueFromBag<Int32Enum>
	|
	|-RVA: 0xF745D0 Offset: 0xF72FD0 VA: 0x180F745D0
	|-UxmlAttributeDescription.TryGetValueFromBag<object>
	|
	|-RVA: 0xF74330 Offset: 0xF72D30 VA: 0x180F74330
	|-UxmlAttributeDescription.TryGetValueFromBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF73AD0 Offset: 0xF724D0 VA: 0x180F73AD0
	|-UxmlAttributeDescription.GetValueFromBag<bool>
	|
	|-RVA: 0xF73BD0 Offset: 0xF725D0 VA: 0x180F73BD0
	|-UxmlAttributeDescription.GetValueFromBag<double>
	|
	|-RVA: 0xF73CD0 Offset: 0xF726D0 VA: 0x180F73CD0
	|-UxmlAttributeDescription.GetValueFromBag<Hash128>
	|
	|-RVA: 0xF74030 Offset: 0xF72A30 VA: 0x180F74030
	|-UxmlAttributeDescription.GetValueFromBag<int>
	|-UxmlAttributeDescription.GetValueFromBag<Int32Enum>
	|-UxmlAttributeDescription.GetValueFromBag<uint>
	|
	|-RVA: 0xF74130 Offset: 0xF72B30 VA: 0x180F74130
	|-UxmlAttributeDescription.GetValueFromBag<long>
	|-UxmlAttributeDescription.GetValueFromBag<object>
	|-UxmlAttributeDescription.GetValueFromBag<ulong>
	|
	|-RVA: 0xF74230 Offset: 0xF72C30 VA: 0x180F74230
	|-UxmlAttributeDescription.GetValueFromBag<float>
	|
	|-RVA: 0xF73E00 Offset: 0xF72800 VA: 0x180F73E00
	|-UxmlAttributeDescription.GetValueFromBag<__Il2CppFullySharedGenericType>
	*/
}
