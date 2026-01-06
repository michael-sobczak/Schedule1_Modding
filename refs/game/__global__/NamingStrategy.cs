public abstract class NamingStrategy // TypeDefIndex: 11270
{
	// Fields
	[CompilerGenerated]
	private bool <ProcessDictionaryKeys>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ProcessExtensionDataNames>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <OverrideSpecifiedNames>k__BackingField; // 0x12

	// Properties
	public bool ProcessDictionaryKeys { get; set; }
	public bool ProcessExtensionDataNames { get; set; }
	public bool OverrideSpecifiedNames { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_ProcessDictionaryKeys() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void set_ProcessDictionaryKeys(bool value) { }

	[CompilerGenerated]
	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_ProcessExtensionDataNames() { }

	[CompilerGenerated]
	// RVA: 0x498A90 Offset: 0x497490 VA: 0x180498A90
	public void set_ProcessExtensionDataNames(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4B9D00 Offset: 0x4B8700 VA: 0x1804B9D00
	public bool get_OverrideSpecifiedNames() { }

	[CompilerGenerated]
	// RVA: 0x4B9D60 Offset: 0x4B8760 VA: 0x1804B9D60
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0x1DAE930 Offset: 0x1DAD330 VA: 0x181DAE930 Slot: 4
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0x1DAE820 Offset: 0x1DAD220 VA: 0x181DAE820 Slot: 5
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0x1DAE800 Offset: 0x1DAD200 VA: 0x181DAE800 Slot: 6
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string ResolvePropertyName(string name);

	// RVA: 0x1DAE840 Offset: 0x1DAD240 VA: 0x181DAE840 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(2)]
	// RVA: 0x1DAE6E0 Offset: 0x1DAD0E0 VA: 0x181DAE6E0 Slot: 0
	public override bool Equals(object obj) { }

	[NullableContext(2)]
	// RVA: 0x1DAE620 Offset: 0x1DAD020 VA: 0x181DAE620
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
