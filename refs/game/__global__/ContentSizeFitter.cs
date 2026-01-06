public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 16430
{
	// Fields
	[SerializeField]
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x20
	[SerializeField]
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x24
	private RectTransform m_Rect; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x30

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x2F18E60 Offset: 0x2F17860 VA: 0x182F18E60
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x2F18EC0 Offset: 0x2F178C0 VA: 0x182F18EC0
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x2F18DD0 Offset: 0x2F177D0 VA: 0x182F18DD0
	private RectTransform get_rectTransform() { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	protected void .ctor() { }

	// RVA: 0x2F18CE0 Offset: 0x2F176E0 VA: 0x182F18CE0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F18C60 Offset: 0x2F17660 VA: 0x182F18C60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F18D00 Offset: 0x2F17700 VA: 0x182F18D00 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2F18B80 Offset: 0x2F17580 VA: 0x182F18B80
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x2F18D90 Offset: 0x2F17790 VA: 0x182F18D90 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x2F18DC0 Offset: 0x2F177C0 VA: 0x182F18DC0 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x2F18D10 Offset: 0x2F17710 VA: 0x182F18D10
	protected void SetDirty() { }
}
