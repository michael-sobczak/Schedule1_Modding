internal abstract class ExtensionQuery : Query // TypeDefIndex: 8552
{
	// Fields
	protected string prefix; // 0x18
	protected string name; // 0x20
	protected XsltContext xsltContext; // 0x28
	private ResetableIterator _queryIterator; // 0x30

	// Properties
	public override XPathNavigator Current { get; }
	public override int CurrentPosition { get; }
	protected string QName { get; }
	public override int Count { get; }
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x2499120 Offset: 0x2497B20 VA: 0x182499120
	public void .ctor(string prefix, string name) { }

	// RVA: 0x2499170 Offset: 0x2497B70 VA: 0x182499170
	protected void .ctor(ExtensionQuery other) { }

	// RVA: 0x2499100 Offset: 0x2497B00 VA: 0x182499100 Slot: 12
	public override void Reset() { }

	// RVA: 0x24992F0 Offset: 0x2497CF0 VA: 0x1824992F0 Slot: 8
	public override XPathNavigator get_Current() { }

	// RVA: 0x24989D0 Offset: 0x24973D0 VA: 0x1824989D0 Slot: 15
	public override XPathNavigator Advance() { }

	// RVA: 0x24992C0 Offset: 0x2497CC0 VA: 0x1824992C0 Slot: 9
	public override int get_CurrentPosition() { }

	// RVA: 0x2498A60 Offset: 0x2497460 VA: 0x182498A60
	protected object ProcessResult(object value) { }

	// RVA: 0x2499390 Offset: 0x2497D90 VA: 0x182499390
	protected string get_QName() { }

	// RVA: 0x2499290 Offset: 0x2497C90 VA: 0x182499290 Slot: 10
	public override int get_Count() { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 16
	public override XPathResultType get_StaticType() { }
}
