public class VehicleData : SaveData // TypeDefIndex: 1123
{
	// Fields
	public string GUID; // 0x28
	public string VehicleCode; // 0x30
	public Vector3 Position; // 0x38
	public Quaternion Rotation; // 0x44
	public string Color; // 0x58
	public ItemSet VehicleContents; // 0x60

	// Methods

	// RVA: 0x5F24B0 Offset: 0x5F0EB0 VA: 0x1805F24B0
	public void .ctor(Guid guid, string code, Vector3 pos, Quaternion rot, EVehicleColor col, ItemSet vehicleContents) { }
}
