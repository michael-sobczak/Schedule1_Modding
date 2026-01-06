public class EffectFromProfile : MonoBehaviour // TypeDefIndex: 250
{
	// Fields
	public const string ClassName = "EffectFromProfile";
	[SerializeField]
	private EffectAbstractBase m_EffectProfile; // 0x20
	private EffectAbstractBase m_EffectInstance; // 0x28

	// Properties
	public EffectAbstractBase effectProfile { get; set; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public EffectAbstractBase get_effectProfile() { }

	// RVA: 0x699060 Offset: 0x697A60 VA: 0x180699060
	public void set_effectProfile(EffectAbstractBase value) { }

	// RVA: 0x698D80 Offset: 0x697780 VA: 0x180698D80
	public void InitInstanceFromProfile() { }

	// RVA: 0x698ED0 Offset: 0x6978D0 VA: 0x180698ED0
	private void OnEnable() { }

	// RVA: 0x698E50 Offset: 0x697850 VA: 0x180698E50
	private void OnDisable() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
