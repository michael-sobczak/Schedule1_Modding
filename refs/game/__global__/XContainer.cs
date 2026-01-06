public abstract class XContainer : XNode // TypeDefIndex: 18617
{
	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x23C6840 Offset: 0x23C5240 VA: 0x1823C6840
	internal void .ctor(XContainer other) { }

	// RVA: 0x23C69B0 Offset: 0x23C53B0 VA: 0x1823C69B0
	public XNode get_LastNode() { }

	// RVA: 0x23C4ED0 Offset: 0x23C38D0 VA: 0x1823C4ED0
	public void Add(object content) { }

	[IteratorStateMachine(typeof(XContainer.<Nodes>d__18))]
	// RVA: 0x23C5B50 Offset: 0x23C4550 VA: 0x1823C5B50
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x23C6280 Offset: 0x23C4C80 VA: 0x1823C6280
	public void RemoveNodes() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x23C44B0 Offset: 0x23C2EB0 VA: 0x1823C44B0
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x23C4880 Offset: 0x23C3280 VA: 0x1823C4880
	internal void AddNode(XNode n) { }

	// RVA: 0x23C47E0 Offset: 0x23C31E0 VA: 0x1823C47E0
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x23C4AE0 Offset: 0x23C34E0 VA: 0x1823C4AE0
	internal void AddString(string s) { }

	// RVA: 0x23C4920 Offset: 0x23C3320 VA: 0x1823C4920
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x23C5390 Offset: 0x23C3D90 VA: 0x1823C5390
	internal void AppendNode(XNode n) { }

	// RVA: 0x23C5290 Offset: 0x23C3C90 VA: 0x1823C5290
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x23C54C0 Offset: 0x23C3EC0 VA: 0x1823C54C0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x23C55C0 Offset: 0x23C3FC0 VA: 0x1823C55C0
	internal void ConvertTextToNode() { }

	// RVA: 0x23C56E0 Offset: 0x23C40E0 VA: 0x1823C56E0
	internal static string GetStringValue(object value) { }

	// RVA: 0x23C5BD0 Offset: 0x23C45D0 VA: 0x1823C5BD0
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x23C5CE0 Offset: 0x23C46E0 VA: 0x1823C5CE0
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x23C5F90 Offset: 0x23C4990 VA: 0x1823C5F90
	internal void RemoveNode(XNode n) { }

	// RVA: 0x23C61A0 Offset: 0x23C4BA0 VA: 0x1823C61A0
	private void RemoveNodesSkipNotify() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x23C66E0 Offset: 0x23C50E0 VA: 0x1823C66E0
	internal void WriteContentTo(XmlWriter writer) { }
}
