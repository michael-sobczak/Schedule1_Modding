internal struct ExpressionMultiplier // TypeDefIndex: 7191
{
	// Fields
	public const int Infinity = 100;
	private ExpressionMultiplierType m_Type; // 0x0
	public int min; // 0x4
	public int max; // 0x8

	// Properties
	public ExpressionMultiplierType type { get; set; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public ExpressionMultiplierType get_type() { }

	// RVA: 0x2E44060 Offset: 0x2E42A60 VA: 0x182E44060
	public void set_type(ExpressionMultiplierType value) { }

	// RVA: 0x2E44040 Offset: 0x2E42A40 VA: 0x182E44040
	public void .ctor(ExpressionMultiplierType type = 0) { }

	// RVA: 0x2E43FC0 Offset: 0x2E429C0 VA: 0x182E43FC0
	private void SetType(ExpressionMultiplierType value) { }
}
