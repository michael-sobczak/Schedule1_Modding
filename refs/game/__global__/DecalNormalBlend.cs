internal enum DecalNormalBlend // TypeDefIndex: 8981
{
	// Fields
	public int value__; // 0x0
	[Tooltip("Low quality of normal reconstruction (Uses 1 sample).")]
	public const DecalNormalBlend Low = 0;
	[Tooltip("Medium quality of normal reconstruction (Uses 5 samples).")]
	public const DecalNormalBlend Medium = 1;
	[Tooltip("High quality of normal reconstruction (Uses 9 samples).")]
	public const DecalNormalBlend High = 2;
}
