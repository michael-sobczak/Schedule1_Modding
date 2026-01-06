internal class StyleVariableResolver // TypeDefIndex: 6907
{
	// Fields
	internal const int kMaxResolves = 100;
	private static StyleSyntaxParser s_SyntaxParser; // 0x0
	private StylePropertyValueMatcher m_Matcher; // 0x10
	private List<StylePropertyValue> m_ResolvedValues; // 0x18
	private Stack<string> m_ResolvedVarStack; // 0x20
	private StyleProperty m_Property; // 0x28
	private Stack<StyleVariableResolver.ResolveContext> m_ContextStack; // 0x30
	private StyleVariableResolver.ResolveContext m_CurrentContext; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StyleVariableContext <variableContext>k__BackingField; // 0x48

	// Properties
	private StyleSheet currentSheet { get; }
	private StyleValueHandle[] currentHandles { get; }
	public List<StylePropertyValue> resolvedValues { get; }
	public StyleVariableContext variableContext { get; set; }

	// Methods

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	private StyleSheet get_currentSheet() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	private StyleValueHandle[] get_currentHandles() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<StylePropertyValue> get_resolvedValues() { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public StyleVariableContext get_variableContext() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_variableContext(StyleVariableContext value) { }

	// RVA: 0x2F07B50 Offset: 0x2F06550 VA: 0x182F07B50
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x2F07E00 Offset: 0x2F06800 VA: 0x182F07E00
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x2F07D70 Offset: 0x2F06770 VA: 0x182F07D70
	private void PopContext() { }

	// RVA: 0x2F07A30 Offset: 0x2F06430 VA: 0x182F07A30
	public void AddValue(StyleValueHandle handle) { }

	// RVA: 0x2F08280 Offset: 0x2F06C80 VA: 0x182F08280
	public bool ResolveVarFunction(ref int index) { }

	// RVA: 0x2F08140 Offset: 0x2F06B40 VA: 0x182F08140
	private StyleVariableResolver.Result ResolveVarFunction(ref int index, int argc, string varName) { }

	// RVA: 0x2F087E0 Offset: 0x2F071E0 VA: 0x182F087E0
	public bool ValidateResolvedValues() { }

	// RVA: 0x2F08460 Offset: 0x2F06E60 VA: 0x182F08460
	private StyleVariableResolver.Result ResolveVariable(string variableName) { }

	// RVA: 0x2F07EB0 Offset: 0x2F068B0 VA: 0x182F07EB0
	private StyleVariableResolver.Result ResolveFallback(ref int index) { }

	// RVA: 0x2F07C20 Offset: 0x2F06620 VA: 0x182F07C20
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) { }

	// RVA: 0x2F089E0 Offset: 0x2F073E0 VA: 0x182F089E0
	public void .ctor() { }

	// RVA: 0x2F08960 Offset: 0x2F07360 VA: 0x182F08960
	private static void .cctor() { }
}
