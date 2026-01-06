public class BaseSpriteItemData // TypeDefIndex: 483
{
	// Fields
	public SpriteSheetData spriteSheetData; // 0x10
	[CompilerGenerated]
	private Matrix4x4 <modelMatrix>k__BackingField; // 0x18
	[CompilerGenerated]
	private BaseSpriteItemData.SpriteState <state>k__BackingField; // 0x58
	[CompilerGenerated]
	private Vector3 <spritePosition>k__BackingField; // 0x5C
	[CompilerGenerated]
	private float <startTime>k__BackingField; // 0x68
	[CompilerGenerated]
	private float <endTime>k__BackingField; // 0x6C
	public float delay; // 0x70

	// Properties
	public Matrix4x4 modelMatrix { get; set; }
	public BaseSpriteItemData.SpriteState state { get; set; }
	public Vector3 spritePosition { get; set; }
	public float startTime { get; set; }
	public float endTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5660E0 Offset: 0x564AE0 VA: 0x1805660E0
	public Matrix4x4 get_modelMatrix() { }

	[CompilerGenerated]
	// RVA: 0x566110 Offset: 0x564B10 VA: 0x180566110
	protected void set_modelMatrix(Matrix4x4 value) { }

	[CompilerGenerated]
	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public BaseSpriteItemData.SpriteState get_state() { }

	[CompilerGenerated]
	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	protected void set_state(BaseSpriteItemData.SpriteState value) { }

	[CompilerGenerated]
	// RVA: 0x4D6390 Offset: 0x4D4D90 VA: 0x1804D6390
	public Vector3 get_spritePosition() { }

	[CompilerGenerated]
	// RVA: 0x4D6630 Offset: 0x4D5030 VA: 0x1804D6630
	public void set_spritePosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x4CD9E0 Offset: 0x4CC3E0 VA: 0x1804CD9E0
	public float get_startTime() { }

	[CompilerGenerated]
	// RVA: 0xA7BCB0 Offset: 0xA7A6B0 VA: 0x180A7BCB0
	protected void set_startTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x4CD190 Offset: 0x4CBB90 VA: 0x1804CD190
	public float get_endTime() { }

	[CompilerGenerated]
	// RVA: 0xA7BCA0 Offset: 0xA7A6A0 VA: 0x180A7BCA0
	protected void set_endTime(float value) { }

	// RVA: 0xA7BC80 Offset: 0xA7A680 VA: 0x180A7BC80
	public void .ctor() { }

	// RVA: 0xA7BB70 Offset: 0xA7A570 VA: 0x180A7BB70
	public void SetTRSMatrix(Vector3 worldPosition, Quaternion rotation, Vector3 scale) { }

	// RVA: 0xA7BC10 Offset: 0xA7A610 VA: 0x180A7BC10
	public void Start() { }

	// RVA: 0xA7BB20 Offset: 0xA7A520 VA: 0x180A7BB20
	public void Continue() { }

	// RVA: 0xA7BB50 Offset: 0xA7A550 VA: 0x180A7BB50
	public void Reset() { }

	// RVA: 0xA7BAF0 Offset: 0xA7A4F0 VA: 0x180A7BAF0
	public static float CalculateStartTimeWithDelay(float delay) { }

	// RVA: 0xA7BAC0 Offset: 0xA7A4C0 VA: 0x180A7BAC0
	public static float CalculateEndTime(float startTime, int itemCount, int animationSpeed) { }
}
