public sealed class RectTransform : Transform // TypeDefIndex: 11887
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2CC5360 Offset: 0x2CC3D60 VA: 0x182CC5360
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGenerated]
	// RVA: 0x2CC59E0 Offset: 0x2CC43E0 VA: 0x182CC59E0
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x2CC58F0 Offset: 0x2CC42F0 VA: 0x182CC58F0
	public Rect get_rect() { }

	// RVA: 0x2CC5510 Offset: 0x2CC3F10 VA: 0x182CC5510
	public Vector2 get_anchorMin() { }

	// RVA: 0x2CC5B80 Offset: 0x2CC4580 VA: 0x182CC5B80
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x2CC5470 Offset: 0x2CC3E70 VA: 0x182CC5470
	public Vector2 get_anchorMax() { }

	// RVA: 0x2CC5AF0 Offset: 0x2CC44F0 VA: 0x182CC5AF0
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x2CC55B0 Offset: 0x2CC3FB0 VA: 0x182CC55B0
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x2CC5CF0 Offset: 0x2CC46F0 VA: 0x182CC5CF0
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x2CC5990 Offset: 0x2CC4390 VA: 0x182CC5990
	public Vector2 get_sizeDelta() { }

	// RVA: 0x2CC62D0 Offset: 0x2CC4CD0 VA: 0x182CC62D0
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x2CC5850 Offset: 0x2CC4250 VA: 0x182CC5850
	public Vector2 get_pivot() { }

	// RVA: 0x2CC6240 Offset: 0x2CC4C40 VA: 0x182CC6240
	public void set_pivot(Vector2 value) { }

	// RVA: 0x2CC5BC0 Offset: 0x2CC45C0 VA: 0x182CC5BC0
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x2CC5720 Offset: 0x2CC4120 VA: 0x182CC5720
	public Vector2 get_offsetMin() { }

	// RVA: 0x2CC5F80 Offset: 0x2CC4980 VA: 0x182CC5F80
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x2CC5600 Offset: 0x2CC4000 VA: 0x182CC5600
	public Vector2 get_offsetMax() { }

	// RVA: 0x2CC5D30 Offset: 0x2CC4730 VA: 0x182CC5D30
	public void set_offsetMax(Vector2 value) { }

	[NativeMethod("UpdateIfTransformDispatchIsDirty")]
	// RVA: 0x2CC48E0 Offset: 0x2CC32E0 VA: 0x182CC48E0
	public void ForceUpdateRectTransforms() { }

	// RVA: 0x2CC4920 Offset: 0x2CC3320 VA: 0x182CC4920
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x2CC4BF0 Offset: 0x2CC35F0 VA: 0x182CC4BF0
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x2CC4F10 Offset: 0x2CC3910 VA: 0x182CC4F10
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC4EB0 Offset: 0x2CC38B0 VA: 0x182CC4EB0
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x2CC4A60 Offset: 0x2CC3460 VA: 0x182CC4A60
	private Vector2 GetParentSize() { }

	// RVA: 0x2CB9B50 Offset: 0x2CB8550 VA: 0x182CB9B50
	public void .ctor() { }

	// RVA: 0x2CC58A0 Offset: 0x2CC42A0 VA: 0x182CC58A0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2CC54C0 Offset: 0x2CC3EC0 VA: 0x182CC54C0
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x2CC5B30 Offset: 0x2CC4530 VA: 0x182CC5B30
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x2CC5420 Offset: 0x2CC3E20 VA: 0x182CC5420
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x2CC5AA0 Offset: 0x2CC44A0 VA: 0x182CC5AA0
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x2CC5560 Offset: 0x2CC3F60 VA: 0x182CC5560
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x2CC5CA0 Offset: 0x2CC46A0 VA: 0x182CC5CA0
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x2CC5940 Offset: 0x2CC4340 VA: 0x182CC5940
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x2CC6280 Offset: 0x2CC4C80 VA: 0x182CC6280
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x2CC5800 Offset: 0x2CC4200 VA: 0x182CC5800
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x2CC61F0 Offset: 0x2CC4BF0 VA: 0x182CC61F0
	private void set_pivot_Injected(ref Vector2 value) { }
}
