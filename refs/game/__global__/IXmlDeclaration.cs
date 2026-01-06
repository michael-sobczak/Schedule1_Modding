internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 11415
{
	// Properties
	public abstract string Version { get; }
	public abstract string Encoding { get; set; }
	public abstract string Standalone { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Encoding();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Encoding(string value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Standalone();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Standalone(string value);
}
