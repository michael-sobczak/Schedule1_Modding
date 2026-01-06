public struct StencilState : IEquatable<StencilState> // TypeDefIndex: 12275
{
	// Fields
	private byte m_Enabled; // 0x0
	private byte m_ReadMask; // 0x1
	private byte m_WriteMask; // 0x2
	private byte m_Padding; // 0x3
	private byte m_CompareFunctionFront; // 0x4
	private byte m_PassOperationFront; // 0x5
	private byte m_FailOperationFront; // 0x6
	private byte m_ZFailOperationFront; // 0x7
	private byte m_CompareFunctionBack; // 0x8
	private byte m_PassOperationBack; // 0x9
	private byte m_FailOperationBack; // 0xA
	private byte m_ZFailOperationBack; // 0xB

	// Properties
	public static StencilState defaultValue { get; }
	public bool enabled { get; set; }
	public byte readMask { get; set; }
	public byte writeMask { get; set; }
	public CompareFunction compareFunctionFront { get; set; }
	public StencilOp passOperationFront { get; set; }
	public StencilOp failOperationFront { get; set; }
	public StencilOp zFailOperationFront { get; set; }
	public CompareFunction compareFunctionBack { get; set; }
	public StencilOp passOperationBack { get; set; }
	public StencilOp failOperationBack { get; set; }
	public StencilOp zFailOperationBack { get; set; }

	// Methods

	// RVA: 0x2CFE2A0 Offset: 0x2CFCCA0 VA: 0x182CFE2A0
	public static StencilState get_defaultValue() { }

	// RVA: 0x2CFE220 Offset: 0x2CFCC20 VA: 0x182CFE220
	public void .ctor(bool enabled = True, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = 8, StencilOp passOperation = 0, StencilOp failOperation = 0, StencilOp zFailOperation = 0) { }

	// RVA: 0x2CFE150 Offset: 0x2CFCB50 VA: 0x182CFE150
	public void .ctor(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack) { }

	// RVA: 0x2CFE330 Offset: 0x2CFCD30 VA: 0x182CFE330
	public bool get_enabled() { }

	// RVA: 0x2CFE400 Offset: 0x2CFCE00 VA: 0x182CFE400
	public void set_enabled(bool value) { }

	// RVA: 0x2CFE3C0 Offset: 0x2CFCDC0 VA: 0x182CFE3C0
	public byte get_readMask() { }

	// RVA: 0x2776630 Offset: 0x2775030 VA: 0x182776630
	public void set_readMask(byte value) { }

	// RVA: 0x2CFE3D0 Offset: 0x2CFCDD0 VA: 0x182CFE3D0
	public byte get_writeMask() { }

	// RVA: 0x27763D0 Offset: 0x2774DD0 VA: 0x1827763D0
	public void set_writeMask(byte value) { }

	// RVA: 0x2CFE110 Offset: 0x2CFCB10 VA: 0x182CFE110
	public void SetCompareFunction(CompareFunction value) { }

	// RVA: 0x2CFE130 Offset: 0x2CFCB30 VA: 0x182CFE130
	public void SetPassOperation(StencilOp value) { }

	// RVA: 0x2CFE120 Offset: 0x2CFCB20 VA: 0x182CFE120
	public void SetFailOperation(StencilOp value) { }

	// RVA: 0x2CFE140 Offset: 0x2CFCB40 VA: 0x182CFE140
	public void SetZFailOperation(StencilOp value) { }

	// RVA: 0x2CFE290 Offset: 0x2CFCC90 VA: 0x182CFE290
	public CompareFunction get_compareFunctionFront() { }

	// RVA: 0x27639A0 Offset: 0x27623A0 VA: 0x1827639A0
	public void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x2CFE3B0 Offset: 0x2CFCDB0 VA: 0x182CFE3B0
	public StencilOp get_passOperationFront() { }

	// RVA: 0x2CFE470 Offset: 0x2CFCE70 VA: 0x182CFE470
	public void set_passOperationFront(StencilOp value) { }

	// RVA: 0x2CFE390 Offset: 0x2CFCD90 VA: 0x182CFE390
	public StencilOp get_failOperationFront() { }

	// RVA: 0x2CFE460 Offset: 0x2CFCE60 VA: 0x182CFE460
	public void set_failOperationFront(StencilOp value) { }

	// RVA: 0x2CFE3F0 Offset: 0x2CFCDF0 VA: 0x182CFE3F0
	public StencilOp get_zFailOperationFront() { }

	// RVA: 0x2CFE490 Offset: 0x2CFCE90 VA: 0x182CFE490
	public void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x2CFE280 Offset: 0x2CFCC80 VA: 0x182CFE280
	public CompareFunction get_compareFunctionBack() { }

	// RVA: 0x48A520 Offset: 0x488F20 VA: 0x18048A520
	public void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x2CFE3A0 Offset: 0x2CFCDA0 VA: 0x182CFE3A0
	public StencilOp get_passOperationBack() { }

	// RVA: 0x2A13850 Offset: 0x2A12250 VA: 0x182A13850
	public void set_passOperationBack(StencilOp value) { }

	// RVA: 0x2CFE380 Offset: 0x2CFCD80 VA: 0x182CFE380
	public StencilOp get_failOperationBack() { }

	// RVA: 0x2A13840 Offset: 0x2A12240 VA: 0x182A13840
	public void set_failOperationBack(StencilOp value) { }

	// RVA: 0x2CFE3E0 Offset: 0x2CFCDE0 VA: 0x182CFE3E0
	public StencilOp get_zFailOperationBack() { }

	// RVA: 0x2CFE480 Offset: 0x2CFCE80 VA: 0x182CFE480
	public void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x2CFDE50 Offset: 0x2CFC850 VA: 0x182CFDE50 Slot: 4
	public bool Equals(StencilState other) { }

	// RVA: 0x2CFDEC0 Offset: 0x2CFC8C0 VA: 0x182CFDEC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CFE010 Offset: 0x2CFCA10 VA: 0x182CFE010 Slot: 2
	public override int GetHashCode() { }
}
