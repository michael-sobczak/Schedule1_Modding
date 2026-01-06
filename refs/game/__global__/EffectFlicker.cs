public class EffectFlicker : EffectAbstractBase // TypeDefIndex: 249
{
	// Fields
	public const string ClassName = "EffectFlicker";
	[Range(1, 60)]
	public float frequency; // 0x50
	public bool performPauses; // 0x54
	[MinMaxRange(0, 10)]
	public MinMaxRangeFloat flickeringDuration; // 0x58
	[MinMaxRange(0, 10)]
	public MinMaxRangeFloat pauseDuration; // 0x60
	public bool restoreIntensityOnPause; // 0x68
	[MinMaxRange(-5, 5)]
	public MinMaxRangeFloat intensityAmplitude; // 0x6C
	[Range(0, 0.25)]
	public float smoothing; // 0x74
	private float m_CurrentAdditiveIntensity; // 0x78

	// Methods

	// RVA: 0x698AD0 Offset: 0x6974D0 VA: 0x180698AD0 Slot: 4
	public override void InitFrom(EffectAbstractBase source) { }

	// RVA: 0x698C40 Offset: 0x697640 VA: 0x180698C40 Slot: 5
	protected override void OnEnable() { }

	[IteratorStateMachine(typeof(EffectFlicker.<CoUpdate>d__11))]
	// RVA: 0x698A60 Offset: 0x697460 VA: 0x180698A60
	private IEnumerator CoUpdate() { }

	[IteratorStateMachine(typeof(EffectFlicker.<CoFlicker>d__12))]
	// RVA: 0x6989F0 Offset: 0x6973F0 VA: 0x1806989F0
	private IEnumerator CoFlicker() { }

	[IteratorStateMachine(typeof(EffectFlicker.<CoChangeIntensity>d__13))]
	// RVA: 0x698960 Offset: 0x697360 VA: 0x180698960
	private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity) { }

	// RVA: 0x698CC0 Offset: 0x6976C0 VA: 0x180698CC0
	public void .ctor() { }
}
