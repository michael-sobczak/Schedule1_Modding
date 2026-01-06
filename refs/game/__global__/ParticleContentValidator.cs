internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 8269
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0x2569590 Offset: 0x2567F90 VA: 0x182569590
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x25695F0 Offset: 0x2567FF0 VA: 0x1825695F0
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x2569340 Offset: 0x2567D40 VA: 0x182569340 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x2569550 Offset: 0x2567F50 VA: 0x182569550 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x2567E10 Offset: 0x2566810 VA: 0x182567E10 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x25693B0 Offset: 0x2567DB0 VA: 0x1825693B0
	public void Start() { }

	// RVA: 0x2569380 Offset: 0x2567D80 VA: 0x182569380
	public void OpenGroup() { }

	// RVA: 0x2567A90 Offset: 0x2566490 VA: 0x182567A90
	public void CloseGroup() { }

	// RVA: 0x2567E50 Offset: 0x2566850 VA: 0x182567E50
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x2566690 Offset: 0x2565090 VA: 0x182566690
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x2566740 Offset: 0x2565140 VA: 0x182566740
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x25664A0 Offset: 0x2564EA0 VA: 0x1825664A0
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x25663A0 Offset: 0x2564DA0 VA: 0x1825663A0
	public void AddChoice() { }

	// RVA: 0x25668C0 Offset: 0x25652C0 VA: 0x1825668C0
	public void AddSequence() { }

	// RVA: 0x25669C0 Offset: 0x25653C0 VA: 0x1825669C0
	public void AddStar() { }

	// RVA: 0x2566800 Offset: 0x2565200 VA: 0x182566800
	public void AddPlus() { }

	// RVA: 0x2566860 Offset: 0x2565260 VA: 0x182566860
	public void AddQMark() { }

	// RVA: 0x25665A0 Offset: 0x2564FA0 VA: 0x1825665A0
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x2567C40 Offset: 0x2566640 VA: 0x182567C40
	private void Closure(InteriorNode node) { }

	// RVA: 0x2567E90 Offset: 0x2566890 VA: 0x182567E90
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x25670E0 Offset: 0x2565AE0 VA: 0x1825670E0
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0x2567510 Offset: 0x2565F10 VA: 0x182567510
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x2568F20 Offset: 0x2567920 VA: 0x182568F20
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x25679D0 Offset: 0x25663D0 VA: 0x1825679D0
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x2567740 Offset: 0x2566140 VA: 0x182567740
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x2566A20 Offset: 0x2565420 VA: 0x182566A20
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }
}
