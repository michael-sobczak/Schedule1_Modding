public class ModifierPathRelativeTranslation : CGModule, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10740
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path A", ModifiesData = True)]
	public CGModuleInputSlot InPath; // 0xC0
	[HideInInspector]
	[OutputSlotInfo(typeof(CGPath))]
	public CGModuleOutputSlot OutPath; // 0xC8
	[SerializeField]
	[Tooltip("The (base) translation distance")]
	[Label("Translation", "")]
	private float lateralTranslation; // 0xD0
	[AnimationCurveEx("    Multiplier", "")]
	[Tooltip("Defines translation multiplier, depending on the Relative Distance (between 0 and 1) of a point on the path")]
	[SerializeField]
	private AnimationCurve multiplier; // 0xD8
	[Tooltip("The translation angle, in degrees")]
	[SerializeField]
	private float angle; // 0xE0

	// Properties
	public float LateralTranslation { get; set; }
	public float Angle { get; set; }
	public AnimationCurve Multiplier { get; set; }
	public bool PathIsClosed { get; }

	// Methods

	// RVA: 0x510840 Offset: 0x50F240 VA: 0x180510840
	public float get_LateralTranslation() { }

	// RVA: 0x527110 Offset: 0x525B10 VA: 0x180527110
	public void set_LateralTranslation(float value) { }

	// RVA: 0x51E8E0 Offset: 0x51D2E0 VA: 0x18051E8E0
	public float get_Angle() { }

	// RVA: 0x538D50 Offset: 0x537750 VA: 0x180538D50
	public void set_Angle(float value) { }

	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90
	public AnimationCurve get_Multiplier() { }

	// RVA: 0x527020 Offset: 0x525A20 VA: 0x180527020
	public void set_Multiplier(AnimationCurve value) { }

	// RVA: 0x538CC0 Offset: 0x5376C0 VA: 0x180538CC0 Slot: 19
	public bool get_PathIsClosed() { }

	// RVA: 0x538520 Offset: 0x536F20 VA: 0x180538520 Slot: 18
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	// RVA: 0x538920 Offset: 0x537320 VA: 0x180538920
	private static void TranslatePoint(int index, CGPath data, bool evaluateTranslationMultiplier, float translation, AnimationCurve translationMultiplier, float angle) { }

	// RVA: 0x5384D0 Offset: 0x536ED0 VA: 0x1805384D0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x538860 Offset: 0x537260 VA: 0x180538860 Slot: 13
	public override void Reset() { }

	// RVA: 0x538800 Offset: 0x537200 VA: 0x180538800 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x538BE0 Offset: 0x5375E0 VA: 0x180538BE0
	public void .ctor() { }
}
