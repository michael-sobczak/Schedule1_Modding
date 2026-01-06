public class MixerMap : ScriptableObject // TypeDefIndex: 1474
{
	// Fields
	public float MapRadius; // 0x18
	public List<MixerMapEffect> Effects; // 0x20

	// Methods

	// RVA: 0x6CA810 Offset: 0x6C9210 VA: 0x1806CA810
	public MixerMapEffect GetEffectAtPoint(Vector2 point) { }

	// RVA: 0x6CAA40 Offset: 0x6C9440 VA: 0x1806CAA40
	public MixerMapEffect GetEffect(Effect property) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}
