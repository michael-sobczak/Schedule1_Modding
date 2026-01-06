public class VolumeComponent : ScriptableObject // TypeDefIndex: 13890
{
	// Fields
	public bool active; // 0x18
	[CompilerGenerated]
	private string <displayName>k__BackingField; // 0x20
	internal readonly List<VolumeParameter> parameterList; // 0x28
	private ReadOnlyCollection<VolumeParameter> m_ParameterReadOnlyCollection; // 0x30

	// Properties
	public string displayName { get; set; }
	public ReadOnlyCollection<VolumeParameter> parameters { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_displayName() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_displayName(string value) { }

	// RVA: 0x2A5AD90 Offset: 0x2A59790 VA: 0x182A5AD90
	public ReadOnlyCollection<VolumeParameter> get_parameters() { }

	// RVA: 0x2A59F30 Offset: 0x2A58930 VA: 0x182A59F30
	internal static void FindParameters(object o, List<VolumeParameter> parameters, Func<FieldInfo, bool> filter) { }

	// RVA: 0x2A5A5E0 Offset: 0x2A58FE0 VA: 0x182A5A5E0 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x2A5A4D0 Offset: 0x2A58ED0 VA: 0x182A5A4D0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2A5A7E0 Offset: 0x2A591E0 VA: 0x182A5A7E0 Slot: 6
	public virtual void Override(VolumeComponent state, float interpFactor) { }

	// RVA: 0x2A5AA00 Offset: 0x2A59400 VA: 0x182A5AA00
	public void SetAllOverridesTo(bool state) { }

	// RVA: 0x2A5AA10 Offset: 0x2A59410 VA: 0x182A5AA10
	internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state) { }

	// RVA: 0x2A5A400 Offset: 0x2A58E00 VA: 0x182A5A400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A59E80 Offset: 0x2A58880 VA: 0x182A59E80
	public bool AnyPropertiesIsOverridden() { }

	// RVA: 0x2A5A4C0 Offset: 0x2A58EC0 VA: 0x182A5A4C0 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x2A5A940 Offset: 0x2A59340 VA: 0x182A5A940
	public void Release() { }

	// RVA: 0x2A5ACE0 Offset: 0x2A596E0 VA: 0x182A5ACE0
	public void .ctor() { }
}
