public class WorldspaceUIElement : MonoBehaviour // TypeDefIndex: 2929
{
	// Fields
	public const float TRANSITION_TIME = 0.1;
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; // 0x20
	[Header("References")]
	public RectTransform RectTransform; // 0x28
	public RectTransform Container; // 0x30
	public TextMeshProUGUI TitleLabel; // 0x38
	public AssignedWorkerDisplay AssignedWorkerDisplay; // 0x40
	private Coroutine scaleRoutine; // 0x48

	// Properties
	public bool IsEnabled { get; set; }
	public bool IsVisible { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsEnabled(bool value) { }

	// RVA: 0x971760 Offset: 0x970160 VA: 0x180971760
	public bool get_IsVisible() { }

	// RVA: 0x9714A0 Offset: 0x96FEA0 VA: 0x1809714A0 Slot: 4
	public virtual void Show() { }

	// RVA: 0x970F60 Offset: 0x96F960 VA: 0x180970F60 Slot: 5
	public virtual void Hide(Action callback) { }

	// RVA: 0x970F00 Offset: 0x96F900 VA: 0x180970F00 Slot: 6
	public virtual void Destroy() { }

	// RVA: 0x9715A0 Offset: 0x96FFA0 VA: 0x1809715A0
	public void UpdatePosition(Vector3 worldSpacePosition) { }

	// RVA: 0x971150 Offset: 0x96FB50 VA: 0x180971150 Slot: 7
	public virtual void SetInternalScale(float scale) { }

	// RVA: 0x971220 Offset: 0x96FC20 VA: 0x180971220
	private void SetScale(float scale, Action callback) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void HoverStart() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void HoverEnd() { }

	// RVA: 0x9710A0 Offset: 0x96FAA0 VA: 0x1809710A0
	public void SetAssignedNPC(NPC npc) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
