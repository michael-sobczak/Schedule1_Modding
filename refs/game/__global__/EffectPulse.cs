public class EffectPulse : EffectAbstractBase // TypeDefIndex: 252
{
	// Fields
	public const string ClassName = "EffectPulse";
	[Range(0.1, 60)]
	public float frequency; // 0x50
	[MinMaxRange(-5, 5)]
	public MinMaxRangeFloat intensityAmplitude; // 0x54

	// Methods

	// RVA: 0x699100 Offset: 0x697B00 VA: 0x180699100 Slot: 4
	public override void InitFrom(EffectAbstractBase source) { }

	// RVA: 0x699240 Offset: 0x697C40 VA: 0x180699240 Slot: 5
	protected override void OnEnable() { }

	[IteratorStateMachine(typeof(EffectPulse.<CoUpdate>d__5))]
	// RVA: 0x699090 Offset: 0x697A90 VA: 0x180699090
	private IEnumerator CoUpdate() { }

	// RVA: 0x6992C0 Offset: 0x697CC0 VA: 0x1806992C0
	public void .ctor() { }
}
