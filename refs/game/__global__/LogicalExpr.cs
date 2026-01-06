internal sealed class LogicalExpr : ValueQuery // TypeDefIndex: 8567
{
	// Fields
	private Operator.Op _op; // 0x18
	private Query _opnd1; // 0x20
	private Query _opnd2; // 0x28
	private static readonly LogicalExpr.cmpXslt[][] s_CompXsltE; // 0x0
	private static readonly LogicalExpr.cmpXslt[][] s_CompXsltO; // 0x8

	// Properties
	public override XPathResultType StaticType { get; }

	// Methods

	// RVA: 0x249DE40 Offset: 0x249C840 VA: 0x18249DE40
	public void .ctor(Operator.Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x249DEA0 Offset: 0x249C8A0 VA: 0x18249DEA0
	private void .ctor(LogicalExpr other) { }

	// RVA: 0x249C710 Offset: 0x249B110 VA: 0x18249C710 Slot: 13
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x249C420 Offset: 0x249AE20 VA: 0x18249C420 Slot: 14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x249EE70 Offset: 0x249D870 VA: 0x18249EE70
	private static bool cmpQueryQueryE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249F170 Offset: 0x249DB70 VA: 0x18249F170
	private static bool cmpQueryQueryO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249EBD0 Offset: 0x249D5D0 VA: 0x18249EBD0
	private static bool cmpQueryNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249F590 Offset: 0x249DF90 VA: 0x18249F590
	private static bool cmpQueryStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249F770 Offset: 0x249E170 VA: 0x18249F770
	private static bool cmpQueryStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249FEB0 Offset: 0x249E8B0 VA: 0x18249FEB0
	private static bool cmpRtfQueryE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A00F0 Offset: 0x249EAF0 VA: 0x1824A00F0
	private static bool cmpRtfQueryO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E810 Offset: 0x249D210 VA: 0x18249E810
	private static bool cmpQueryBoolE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E9D0 Offset: 0x249D3D0 VA: 0x18249E9D0
	private static bool cmpQueryBoolO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249DF10 Offset: 0x249C910 VA: 0x18249DF10
	private static bool cmpBoolBoolE(Operator.Op op, bool n1, bool n2) { }

	// RVA: 0x249DF20 Offset: 0x249C920 VA: 0x18249DF20
	private static bool cmpBoolBoolE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E000 Offset: 0x249CA00 VA: 0x18249E000
	private static bool cmpBoolBoolO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E130 Offset: 0x249CB30 VA: 0x18249E130
	private static bool cmpBoolNumberE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E260 Offset: 0x249CC60 VA: 0x18249E260
	private static bool cmpBoolNumberO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E3A0 Offset: 0x249CDA0 VA: 0x18249E3A0
	private static bool cmpBoolStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249FA10 Offset: 0x249E410 VA: 0x18249FA10
	private static bool cmpRtfBoolE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E490 Offset: 0x249CE90 VA: 0x18249E490
	private static bool cmpBoolStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249FB40 Offset: 0x249E540 VA: 0x18249FB40
	private static bool cmpRtfBoolO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249E7A0 Offset: 0x249D1A0 VA: 0x18249E7A0
	private static bool cmpNumberNumber(Operator.Op op, double n1, double n2) { }

	// RVA: 0x249E600 Offset: 0x249D000 VA: 0x18249E600
	private static bool cmpNumberNumberO(Operator.Op op, double n1, double n2) { }

	// RVA: 0x249E640 Offset: 0x249D040 VA: 0x18249E640
	private static bool cmpNumberNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A0A30 Offset: 0x249F430 VA: 0x1824A0A30
	private static bool cmpStringNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249FCE0 Offset: 0x249E6E0 VA: 0x18249FCE0
	private static bool cmpRtfNumber(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A0BD0 Offset: 0x249F5D0 VA: 0x1824A0BD0
	private static bool cmpStringStringE(Operator.Op op, string n1, string n2) { }

	// RVA: 0x24A0C00 Offset: 0x249F600 VA: 0x1824A0C00
	private static bool cmpStringStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A0740 Offset: 0x249F140 VA: 0x1824A0740
	private static bool cmpRtfStringE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A03D0 Offset: 0x249EDD0 VA: 0x1824A03D0
	private static bool cmpRtfRtfE(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A0CE0 Offset: 0x249F6E0 VA: 0x1824A0CE0
	private static bool cmpStringStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A0860 Offset: 0x249F260 VA: 0x1824A0860
	private static bool cmpRtfStringO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x24A0530 Offset: 0x249EF30 VA: 0x1824A0530
	private static bool cmpRtfRtfO(Operator.Op op, object val1, object val2) { }

	// RVA: 0x249C380 Offset: 0x249AD80 VA: 0x18249C380 Slot: 6
	public override XPathNodeIterator Clone() { }

	// RVA: 0x249C690 Offset: 0x249B090 VA: 0x18249C690
	private static string Rtf(object o) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 16
	public override XPathResultType get_StaticType() { }

	// RVA: 0x249C770 Offset: 0x249B170 VA: 0x18249C770
	private static void .cctor() { }
}
