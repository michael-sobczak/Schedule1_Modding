internal struct SerializableProjectConfiguration // TypeDefIndex: 19218
{
	// Fields
	[JsonRequired]
	[SerializeField]
	internal string[] Keys; // 0x0
	[JsonRequired]
	[SerializeField]
	internal ConfigurationEntry[] Values; // 0x8

	// Properties
	public static SerializableProjectConfiguration Empty { get; }

	// Methods

	// RVA: 0x2B975C0 Offset: 0x2B95FC0 VA: 0x182B975C0
	public static SerializableProjectConfiguration get_Empty() { }
}
