internal abstract class BaseAxisQuery : Query // TypeDefIndex: 8536
{
	// Fields
	internal Query qyInput; // 0x18
	private bool _nameTest; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _nsUri; // 0x38
	private XPathNodeType _typeTest; // 0x40
	protected XPathNavigator currentNode; // 0x48
	protected int position; // 0x50

	// Properties
	protected string Name { get; }
	protected string Namespace { get; }
	protected bool NameTest { get; }
	protected XPathNodeType TypeTest { get; }
	public override int CurrentPosition { get; }
	public override XPathNavigator Current { get; }
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x2495910 Offset: 0x2494310 VA: 0x182495910
	protected void .ctor(Query qyInput) { }

	// RVA: 0x24954C0 Offset: 0x2493EC0 VA: 0x1824954C0
	protected void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x2495870 Offset: 0x2494270 VA: 0x182495870
	protected void .ctor(BaseAxisQuery other) { }

	// RVA: 0x24957B0 Offset: 0x24941B0 VA: 0x1824957B0 Slot: 12
	public override void Reset() { }

	// RVA: 0x2495800 Offset: 0x2494200 VA: 0x182495800 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	protected string get_Name() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	protected string get_Namespace() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	protected bool get_NameTest() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	protected XPathNodeType get_TypeTest() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x24959C0 Offset: 0x24943C0 VA: 0x1824959C0 Slot: 18
	public virtual bool matches(XPathNavigator e) { }

	// RVA: 0x2495750 Offset: 0x2494150 VA: 0x182495750 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 16
	public override XPathResultType get_StaticType() { }
}
