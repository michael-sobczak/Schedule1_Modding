public abstract class InputControl // TypeDefIndex: 7344
{
	// Fields
	protected internal InputStateBlock m_StateBlock; // 0x10
	internal InternedString m_Name; // 0x20
	internal string m_Path; // 0x30
	internal string m_DisplayName; // 0x38
	internal string m_DisplayNameFromLayout; // 0x40
	internal string m_ShortDisplayName; // 0x48
	internal string m_ShortDisplayNameFromLayout; // 0x50
	internal InternedString m_Layout; // 0x58
	internal InternedString m_Variants; // 0x68
	internal InputDevice m_Device; // 0x78
	internal InputControl m_Parent; // 0x80
	internal int m_UsageCount; // 0x88
	internal int m_UsageStartIndex; // 0x8C
	internal int m_AliasCount; // 0x90
	internal int m_AliasStartIndex; // 0x94
	internal int m_ChildCount; // 0x98
	internal int m_ChildStartIndex; // 0x9C
	internal InputControl.ControlFlags m_ControlFlags; // 0xA0
	internal bool m_CachedValueIsStale; // 0xA4
	internal bool m_UnprocessedCachedValueIsStale; // 0xA5
	internal PrimitiveValue m_DefaultState; // 0xA8
	internal PrimitiveValue m_MinValue; // 0xB8
	internal PrimitiveValue m_MaxValue; // 0xC8
	internal FourCC m_OptimizedControlDataType; // 0xD8

	// Properties
	public string name { get; }
	public string displayName { get; set; }
	public string shortDisplayName { get; set; }
	public string path { get; }
	public string layout { get; }
	public string variants { get; }
	public InputDevice device { get; }
	public InputControl parent { get; }
	public ReadOnlyArray<InputControl> children { get; }
	public ReadOnlyArray<InternedString> usages { get; }
	public ReadOnlyArray<InternedString> aliases { get; }
	public InputStateBlock stateBlock { get; }
	public bool noisy { get; set; }
	public bool synthetic { get; set; }
	public InputControl Item { get; }
	public abstract Type valueType { get; }
	public abstract int valueSizeInBytes { get; }
	public float magnitude { get; }
	protected internal void* currentStatePtr { get; }
	protected internal void* previousFrameStatePtr { get; }
	protected internal void* defaultStatePtr { get; }
	protected internal void* noiseMaskPtr { get; }
	protected internal uint stateOffsetRelativeToDeviceRoot { get; }
	public FourCC optimizedControlDataType { get; }
	internal bool isSetupFinished { get; set; }
	internal bool isButton { get; set; }
	internal bool isConfigUpToDate { get; set; }
	internal bool dontReset { get; set; }
	internal bool usesStateFromOtherControl { get; set; }
	internal bool hasDefaultState { get; }

	// Methods

	// RVA: 0x27A30F0 Offset: 0x27A1AF0 VA: 0x1827A30F0
	public string get_name() { }

	// RVA: 0x27A3000 Offset: 0x27A1A00 VA: 0x1827A3000
	public string get_displayName() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_displayName(string value) { }

	// RVA: 0x27A32A0 Offset: 0x27A1CA0 VA: 0x1827A32A0
	public string get_shortDisplayName() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	protected void set_shortDisplayName(string value) { }

	// RVA: 0x27A3160 Offset: 0x27A1B60 VA: 0x1827A3160
	public string get_path() { }

	// RVA: 0x27A30D0 Offset: 0x27A1AD0 VA: 0x1827A30D0
	public string get_layout() { }

	// RVA: 0x27A3400 Offset: 0x27A1E00 VA: 0x1827A3400
	public string get_variants() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public InputDevice get_device() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public InputControl get_parent() { }

	// RVA: 0x27A2F20 Offset: 0x27A1920 VA: 0x1827A2F20
	public ReadOnlyArray<InputControl> get_children() { }

	// RVA: 0x27A3370 Offset: 0x27A1D70 VA: 0x1827A3370
	public ReadOnlyArray<InternedString> get_usages() { }

	// RVA: 0x27A2EA0 Offset: 0x27A18A0 VA: 0x1827A2EA0
	public ReadOnlyArray<InternedString> get_aliases() { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public InputStateBlock get_stateBlock() { }

	// RVA: 0x27A3150 Offset: 0x27A1B50 VA: 0x1827A3150
	public bool get_noisy() { }

	// RVA: 0x27A34A0 Offset: 0x27A1EA0 VA: 0x1827A34A0
	internal void set_noisy(bool value) { }

	// RVA: 0x27A3360 Offset: 0x27A1D60 VA: 0x1827A3360
	public bool get_synthetic() { }

	// RVA: 0x27A35E0 Offset: 0x27A1FE0 VA: 0x1827A35E0
	internal void set_synthetic(bool value) { }

	// RVA: 0x27A2DF0 Offset: 0x27A17F0 VA: 0x1827A2DF0
	public InputControl get_Item(string path) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_valueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_valueSizeInBytes();

	// RVA: 0x27A21F0 Offset: 0x27A0BF0 VA: 0x1827A21F0
	public float get_magnitude() { }

	// RVA: 0x27A2B90 Offset: 0x27A1590 VA: 0x1827A2B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x27A1CD0 Offset: 0x27A06D0 VA: 0x1827A1CD0
	private string DebuggerDisplay() { }

	// RVA: 0x27A21F0 Offset: 0x27A0BF0 VA: 0x1827A21F0
	public float EvaluateMagnitude() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 6
	public virtual float EvaluateMagnitude(void* statePtr) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract object ReadValueFromBufferAsObject(void* buffer, int bufferSize);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object ReadValueFromStateAsObject(void* statePtr);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);

	// RVA: 0x27A2CB0 Offset: 0x27A16B0 VA: 0x1827A2CB0 Slot: 10
	public virtual void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr) { }

	// RVA: 0x27A2D20 Offset: 0x27A1720 VA: 0x1827A2D20 Slot: 11
	public virtual void WriteValueFromObjectIntoState(object value, void* statePtr) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool CompareValue(void* firstStatePtr, void* secondStatePtr);

	// RVA: 0x27A2C00 Offset: 0x27A1600 VA: 0x1827A2C00
	public InputControl TryGetChildControl(string path) { }

	// RVA: -1 Offset: -1
	public TControl TryGetChildControl<TControl>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9CF0 Offset: 0xED86F0 VA: 0x180ED9CF0
	|-InputControl.TryGetChildControl<object>
	*/

	// RVA: 0x27A2230 Offset: 0x27A0C30 VA: 0x1827A2230
	public InputControl GetChildControl(string path) { }

	// RVA: -1 Offset: -1
	public TControl GetChildControl<TControl>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9A70 Offset: 0xED8470 VA: 0x180ED9A70
	|-InputControl.GetChildControl<object>
	*/

	// RVA: 0x27A2D90 Offset: 0x27A1790 VA: 0x1827A2D90
	protected void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	protected virtual void FinishSetup() { }

	// RVA: 0x27A2870 Offset: 0x27A1270 VA: 0x1827A2870
	protected void RefreshConfigurationIfNeeded() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	protected virtual void RefreshConfiguration() { }

	// RVA: 0x27A2FA0 Offset: 0x27A19A0 VA: 0x1827A2FA0
	protected internal void* get_currentStatePtr() { }

	// RVA: 0x27A3280 Offset: 0x27A1C80 VA: 0x1827A3280
	protected internal void* get_previousFrameStatePtr() { }

	// RVA: 0x27A2FC0 Offset: 0x27A19C0 VA: 0x1827A2FC0
	protected internal void* get_defaultStatePtr() { }

	// RVA: 0x27A3110 Offset: 0x27A1B10 VA: 0x1827A3110
	protected internal void* get_noiseMaskPtr() { }

	// RVA: 0x27A3300 Offset: 0x27A1D00 VA: 0x1827A3300
	protected internal uint get_stateOffsetRelativeToDeviceRoot() { }

	// RVA: 0x516290 Offset: 0x514C90 VA: 0x180516290
	public FourCC get_optimizedControlDataType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	// RVA: 0x27A19C0 Offset: 0x27A03C0 VA: 0x1827A19C0
	public void ApplyParameterChanges() { }

	// RVA: 0x27A2B00 Offset: 0x27A1500 VA: 0x1827A2B00
	private void SetOptimizedControlDataType() { }

	// RVA: 0x27A28B0 Offset: 0x27A12B0 VA: 0x1827A28B0
	internal void SetOptimizedControlDataTypeRecursively() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x27A1DF0 Offset: 0x27A07F0 VA: 0x1827A1DF0
	internal void EnsureOptimizationTypeHasNotChanged() { }

	// RVA: 0x27A30C0 Offset: 0x27A1AC0 VA: 0x1827A30C0
	internal bool get_isSetupFinished() { }

	// RVA: 0x27A3480 Offset: 0x27A1E80 VA: 0x1827A3480
	internal void set_isSetupFinished(bool value) { }

	// RVA: 0x27A30A0 Offset: 0x27A1AA0 VA: 0x1827A30A0
	internal bool get_isButton() { }

	// RVA: 0x27A3440 Offset: 0x27A1E40 VA: 0x1827A3440
	internal void set_isButton(bool value) { }

	// RVA: 0x27A30B0 Offset: 0x27A1AB0 VA: 0x1827A30B0
	internal bool get_isConfigUpToDate() { }

	// RVA: 0x27A3460 Offset: 0x27A1E60 VA: 0x1827A3460
	internal void set_isConfigUpToDate(bool value) { }

	// RVA: 0x27A3070 Offset: 0x27A1A70 VA: 0x1827A3070
	internal bool get_dontReset() { }

	// RVA: 0x27A3420 Offset: 0x27A1E20 VA: 0x1827A3420
	internal void set_dontReset(bool value) { }

	// RVA: 0x27A33F0 Offset: 0x27A1DF0 VA: 0x1827A33F0
	internal bool get_usesStateFromOtherControl() { }

	// RVA: 0x27A3600 Offset: 0x27A2000 VA: 0x1827A3600
	internal void set_usesStateFromOtherControl(bool value) { }

	// RVA: 0x27A3080 Offset: 0x27A1A80 VA: 0x1827A3080
	internal bool get_hasDefaultState() { }

	// RVA: 0x27A1BB0 Offset: 0x27A05B0 VA: 0x1827A1BB0
	internal void CallFinishSetupRecursive() { }

	// RVA: 0x27A25F0 Offset: 0x27A0FF0 VA: 0x1827A25F0
	internal string MakeChildPath(string path) { }

	// RVA: 0x27A1A80 Offset: 0x27A0480 VA: 0x1827A1A80
	internal void BakeOffsetIntoStateBlockRecursive(uint offset) { }

	// RVA: 0x27A23D0 Offset: 0x27A0DD0 VA: 0x1827A23D0
	internal int GetDeviceIndex() { }

	// RVA: 0x27A2540 Offset: 0x27A0F40 VA: 0x1827A2540
	internal bool IsValueConsideredPressed(float value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	internal virtual void AddProcessor(object first) { }

	// RVA: 0x27A2860 Offset: 0x27A1260 VA: 0x1827A2860
	internal void MarkAsStale() { }

	// RVA: 0x27A2690 Offset: 0x27A1090 VA: 0x1827A2690
	internal void MarkAsStaleRecursively() { }
}
