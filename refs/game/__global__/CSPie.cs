public class CSPie : CSCircle // TypeDefIndex: 10555
{
	// Fields
	[Range(0, 1)]
	[SerializeField]
	private float m_Roundness; // 0x50
	[SerializeField]
	[RangeEx(0, "maxEmpty", "Empty", "Number of empty slices")]
	private int m_Empty; // 0x54
	[SerializeField]
	[Label(Tooltip = "Eat Mode")]
	private CSPie.EatModeEnum m_Eat; // 0x58

	// Properties
	public float Roundness { get; set; }
	public int Empty { get; set; }
	private int maxEmpty { get; }
	public CSPie.EatModeEnum Eat { get; set; }

	// Methods

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_Roundness() { }

	// RVA: 0x4C3B90 Offset: 0x4C2590 VA: 0x1804C3B90
	public void set_Roundness(float value) { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public int get_Empty() { }

	// RVA: 0x4C3B70 Offset: 0x4C2570 VA: 0x1804C3B70
	public void set_Empty(int value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	private int get_maxEmpty() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public CSPie.EatModeEnum get_Eat() { }

	// RVA: 0x4C3B60 Offset: 0x4C2560 VA: 0x1804C3B60
	public void set_Eat(CSPie.EatModeEnum value) { }

	// RVA: 0x4C3A10 Offset: 0x4C2410 VA: 0x1804C3A10
	private Vector3 cpPosition(int i, int empty, float d) { }

	// RVA: 0x4C2F30 Offset: 0x4C1930 VA: 0x1804C2F30 Slot: 9
	protected override void ApplyShape() { }

	// RVA: 0x4C39E0 Offset: 0x4C23E0 VA: 0x1804C39E0
	public void .ctor() { }
}
