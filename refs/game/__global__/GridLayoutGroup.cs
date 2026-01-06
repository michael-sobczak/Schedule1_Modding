public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 16434
{
	// Fields
	[SerializeField]
	protected GridLayoutGroup.Corner m_StartCorner; // 0x60
	[SerializeField]
	protected GridLayoutGroup.Axis m_StartAxis; // 0x64
	[SerializeField]
	protected Vector2 m_CellSize; // 0x68
	[SerializeField]
	protected Vector2 m_Spacing; // 0x70
	[SerializeField]
	protected GridLayoutGroup.Constraint m_Constraint; // 0x78
	[SerializeField]
	protected int m_ConstraintCount; // 0x7C

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x2F19D60 Offset: 0x2F18760 VA: 0x182F19D60
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x2F19D10 Offset: 0x2F18710 VA: 0x182F19D10
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x2F19B60 Offset: 0x2F18560 VA: 0x182F19B60
	public Vector2 get_cellSize() { }

	// RVA: 0x2F19BA0 Offset: 0x2F185A0 VA: 0x182F19BA0
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x2F19B80 Offset: 0x2F18580 VA: 0x182F19B80
	public Vector2 get_spacing() { }

	// RVA: 0x2F19CB0 Offset: 0x2F186B0 VA: 0x182F19CB0
	public void set_spacing(Vector2 value) { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x2F19C60 Offset: 0x2F18660 VA: 0x182F19C60
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	public int get_constraintCount() { }

	// RVA: 0x2F19C00 Offset: 0x2F18600 VA: 0x182F19C00
	public void set_constraintCount(int value) { }

	// RVA: 0x2F19AF0 Offset: 0x2F184F0 VA: 0x182F19AF0
	protected void .ctor() { }

	// RVA: 0x2F18FA0 Offset: 0x2F179A0 VA: 0x182F18FA0 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x2F191A0 Offset: 0x2F17BA0 VA: 0x182F191A0 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x2F19AD0 Offset: 0x2F184D0 VA: 0x182F19AD0 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x2F19AE0 Offset: 0x2F184E0 VA: 0x182F19AE0 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x2F19380 Offset: 0x2F17D80 VA: 0x182F19380
	private void SetCellsAlongAxis(int axis) { }
}
