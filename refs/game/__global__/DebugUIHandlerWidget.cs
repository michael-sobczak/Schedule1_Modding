public class DebugUIHandlerWidget : MonoBehaviour // TypeDefIndex: 13984
{
	// Fields
	[HideInInspector]
	public Color colorDefault; // 0x20
	[HideInInspector]
	public Color colorSelected; // 0x30
	[CompilerGenerated]
	private DebugUIHandlerWidget <parentUIHandler>k__BackingField; // 0x40
	[CompilerGenerated]
	private DebugUIHandlerWidget <previousUIHandler>k__BackingField; // 0x48
	[CompilerGenerated]
	private DebugUIHandlerWidget <nextUIHandler>k__BackingField; // 0x50
	protected DebugUI.Widget m_Widget; // 0x58

	// Properties
	public DebugUIHandlerWidget parentUIHandler { get; set; }
	public DebugUIHandlerWidget previousUIHandler { get; set; }
	public DebugUIHandlerWidget nextUIHandler { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public DebugUIHandlerWidget get_parentUIHandler() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_parentUIHandler(DebugUIHandlerWidget value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public DebugUIHandlerWidget get_previousUIHandler() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_previousUIHandler(DebugUIHandlerWidget value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public DebugUIHandlerWidget get_nextUIHandler() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_nextUIHandler(DebugUIHandlerWidget value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0 Slot: 5
	internal virtual void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal DebugUI.Widget GetWidget() { }

	// RVA: -1 Offset: -1
	protected T CastWidget<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE79C30 Offset: 0xE78630 VA: 0x180E79C30
	|-DebugUIHandlerWidget.CastWidget<object>
	*/

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void OnDeselection() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void OnAction() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void OnIncrement(bool fast) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void OnDecrement(bool fast) { }

	// RVA: 0x2A5F660 Offset: 0x2A5E060 VA: 0x182A5F660 Slot: 11
	public virtual DebugUIHandlerWidget Previous() { }

	// RVA: 0x2A5F540 Offset: 0x2A5DF40 VA: 0x182A5F540 Slot: 12
	public virtual DebugUIHandlerWidget Next() { }

	// RVA: 0x2A5F710 Offset: 0x2A5E110 VA: 0x182A5F710
	public void .ctor() { }
}
