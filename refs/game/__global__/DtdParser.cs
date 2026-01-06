internal class DtdParser : IDtdParser // TypeDefIndex: 8088
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x250B0F0 Offset: 0x2509AF0 VA: 0x18250B0F0
	private void .ctor() { }

	// RVA: 0x24FF930 Offset: 0x24FE330 VA: 0x1824FF930
	internal static IDtdParser Create() { }

	// RVA: 0x2501A20 Offset: 0x2500420 VA: 0x182501A20
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x2501610 Offset: 0x2500010 VA: 0x182501610
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x250A6B0 Offset: 0x25090B0 VA: 0x18250A6B0 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x250A660 Offset: 0x2509060 VA: 0x18250A660 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x250B360 Offset: 0x2509D60 VA: 0x18250B360
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x250B2A0 Offset: 0x2509CA0 VA: 0x18250B2A0
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x250B390 Offset: 0x2509D90 VA: 0x18250B390
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x250B370 Offset: 0x2509D70 VA: 0x18250B370
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x24CF6C0 Offset: 0x24CE0C0 VA: 0x1824CF6C0
	private bool get_SupportNamespaces() { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	private bool get_Normalize() { }

	// RVA: 0x2505530 Offset: 0x2503F30 VA: 0x182505530
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x25048A0 Offset: 0x25032A0 VA: 0x1825048A0
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x25047D0 Offset: 0x25031D0 VA: 0x1825047D0
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x2504A20 Offset: 0x2503420 VA: 0x182504A20
	private void ParseInternalSubset() { }

	// RVA: 0x2504630 Offset: 0x2503030 VA: 0x182504630
	private void ParseExternalSubset() { }

	// RVA: 0x2504D70 Offset: 0x2503770 VA: 0x182504D70
	private void ParseSubset() { }

	// RVA: 0x2501E90 Offset: 0x2500890 VA: 0x182501E90
	private void ParseAttlistDecl() { }

	// RVA: 0x25026C0 Offset: 0x25010C0 VA: 0x1825026C0
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x2502480 Offset: 0x2500E80 VA: 0x182502480
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x25031C0 Offset: 0x2501BC0 VA: 0x1825031C0
	private void ParseElementDecl() { }

	// RVA: 0x25038F0 Offset: 0x25022F0 VA: 0x1825038F0
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x2504830 Offset: 0x2503230 VA: 0x182504830
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x25035E0 Offset: 0x2501FE0 VA: 0x1825035E0
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x2503DE0 Offset: 0x25027E0 VA: 0x182503DE0
	private void ParseEntityDecl() { }

	// RVA: 0x2504A30 Offset: 0x2503430 VA: 0x182504A30
	private void ParseNotationDecl() { }

	// RVA: 0x24FF720 Offset: 0x24FE120 VA: 0x1824FF720
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x2502DA0 Offset: 0x25017A0 VA: 0x182502DA0
	private void ParseComment() { }

	// RVA: 0x2504C70 Offset: 0x2503670 VA: 0x182504C70
	private void ParsePI() { }

	// RVA: 0x2502F40 Offset: 0x2501940 VA: 0x182502F40
	private void ParseCondSection() { }

	// RVA: 0x2504190 Offset: 0x2502B90 VA: 0x182504190
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x24FFDB0 Offset: 0x24FE7B0 VA: 0x1824FFDB0
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x2509820 Offset: 0x2508220 VA: 0x182509820
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x2509100 Offset: 0x2507B00 VA: 0x182509100
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x2509560 Offset: 0x2507F60 VA: 0x182509560
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x2509140 Offset: 0x2507B40 VA: 0x182509140
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x25074D0 Offset: 0x2505ED0 VA: 0x1825074D0
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x2507600 Offset: 0x2506000 VA: 0x182507600
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x2506A00 Offset: 0x2505400 VA: 0x182506A00
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x25076B0 Offset: 0x25060B0 VA: 0x1825076B0
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x2507960 Offset: 0x2506360 VA: 0x182507960
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x2507B80 Offset: 0x2506580 VA: 0x182507B80
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x2507C00 Offset: 0x2506600 VA: 0x182507C00
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x2507D10 Offset: 0x2506710 VA: 0x182507D10
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x2507E00 Offset: 0x2506800 VA: 0x182507E00
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x2507ED0 Offset: 0x25068D0 VA: 0x182507ED0
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x2505A80 Offset: 0x2504480 VA: 0x182505A80
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x2505B50 Offset: 0x2504550 VA: 0x182505B50
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x25062A0 Offset: 0x2504CA0 VA: 0x1825062A0
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x2506340 Offset: 0x2504D40 VA: 0x182506340
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x2506410 Offset: 0x2504E10 VA: 0x182506410
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x25064E0 Offset: 0x2504EE0 VA: 0x1825064E0
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x2506950 Offset: 0x2505350 VA: 0x182506950
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x25082E0 Offset: 0x2506CE0 VA: 0x1825082E0
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x25081D0 Offset: 0x2506BD0 VA: 0x1825081D0
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x2509340 Offset: 0x2507D40 VA: 0x182509340
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x250A020 Offset: 0x2508A20 VA: 0x18250A020
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x2507F20 Offset: 0x2506920 VA: 0x182507F20
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x2507F90 Offset: 0x2506990 VA: 0x182507F90
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x25080D0 Offset: 0x2506AD0 VA: 0x1825080D0
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x2509440 Offset: 0x2507E40 VA: 0x182509440
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x25094F0 Offset: 0x2507EF0 VA: 0x1825094F0
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x2506A80 Offset: 0x2505480 VA: 0x182506A80
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x2506E30 Offset: 0x2505830 VA: 0x182506E30
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x2506EB0 Offset: 0x25058B0 VA: 0x182506EB0
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x2509130 Offset: 0x2507B30 VA: 0x182509130
	private void ScanName() { }

	// RVA: 0x2509810 Offset: 0x2508210 VA: 0x182509810
	private void ScanQName() { }

	// RVA: 0x2509590 Offset: 0x2507F90 VA: 0x182509590
	private void ScanQName(bool isQName) { }

	// RVA: 0x25058C0 Offset: 0x25042C0 VA: 0x1825058C0
	private bool ReadDataInName() { }

	// RVA: 0x2509170 Offset: 0x2507B70 VA: 0x182509170
	private void ScanNmtoken() { }

	// RVA: 0x24FFA50 Offset: 0x24FE450 VA: 0x1824FFA50
	private bool EatPublicKeyword() { }

	// RVA: 0x24FFB10 Offset: 0x24FE510 VA: 0x1824FFB10
	private bool EatSystemKeyword() { }

	// RVA: 0x24FFBD0 Offset: 0x24FE5D0 VA: 0x1824FFBD0
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x24FFD80 Offset: 0x24FE780 VA: 0x1824FFD80
	private string GetNameString() { }

	// RVA: 0x24FFD80 Offset: 0x24FE780 VA: 0x1824FFD80
	private string GetNmtokenString() { }

	// RVA: 0x25010F0 Offset: 0x24FFAF0 VA: 0x1825010F0
	private string GetValue() { }

	// RVA: 0x2501060 Offset: 0x24FFA60 VA: 0x182501060
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x2505900 Offset: 0x2504300 VA: 0x182505900
	private int ReadData() { }

	// RVA: 0x2501CF0 Offset: 0x25006F0 VA: 0x182501CF0
	private void LoadParsingBuffer() { }

	// RVA: 0x2505A70 Offset: 0x2504470 VA: 0x182505A70
	private void SaveParsingBuffer() { }

	// RVA: 0x2505980 Offset: 0x2504380 VA: 0x182505980
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x25015A0 Offset: 0x24FFFA0 VA: 0x1825015A0
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x25012D0 Offset: 0x24FFCD0 VA: 0x1825012D0
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x2501170 Offset: 0x24FFB70 VA: 0x182501170
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x250AEB0 Offset: 0x25098B0 VA: 0x18250AEB0
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x250A0D0 Offset: 0x2508AD0 VA: 0x18250A0D0
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x250A230 Offset: 0x2508C30 VA: 0x18250A230
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x250A370 Offset: 0x2508D70 VA: 0x18250A370
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x2501CE0 Offset: 0x25006E0 VA: 0x182501CE0
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x250B2B0 Offset: 0x2509CB0 VA: 0x18250B2B0
	private int get_LineNo() { }

	// RVA: 0x250B300 Offset: 0x2509D00 VA: 0x18250B300
	private int get_LinePos() { }

	// RVA: 0x250B1E0 Offset: 0x2509BE0 VA: 0x18250B1E0
	private string get_BaseUriStr() { }

	// RVA: 0x2501E00 Offset: 0x2500800 VA: 0x182501E00
	private void OnUnexpectedError() { }

	// RVA: 0x250A980 Offset: 0x2509380 VA: 0x18250A980
	private void Throw(int curPos, string res) { }

	// RVA: 0x250A9F0 Offset: 0x25093F0 VA: 0x18250A9F0
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x250ACF0 Offset: 0x25096F0 VA: 0x18250ACF0
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x250ABB0 Offset: 0x25095B0 VA: 0x18250ABB0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x250A770 Offset: 0x2509170 VA: 0x18250A770
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x250A6F0 Offset: 0x25090F0 VA: 0x18250A6F0
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x250A7F0 Offset: 0x25091F0 VA: 0x18250A7F0
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x250A810 Offset: 0x2509210 VA: 0x18250A810
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x2505440 Offset: 0x2503E40 VA: 0x182505440
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x250A470 Offset: 0x2508E70 VA: 0x18250A470
	internal static string StripSpaces(string value) { }
}
