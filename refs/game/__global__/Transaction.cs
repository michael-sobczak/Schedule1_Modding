public class Transaction // TypeDefIndex: 3197
{
	// Fields
	public string transaction_Name; // 0x10
	public float unit_Amount; // 0x18
	public float quantity; // 0x1C
	public string transaction_Note; // 0x20

	// Properties
	public float total_Amount { get; }

	// Methods

	// RVA: 0x9D70E0 Offset: 0x9D5AE0 VA: 0x1809D70E0
	public float get_total_Amount() { }

	// RVA: 0x9D7010 Offset: 0x9D5A10 VA: 0x1809D7010
	public void .ctor(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) { }
}
