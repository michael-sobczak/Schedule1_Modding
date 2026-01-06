internal sealed class LikeNode : BinaryNode // TypeDefIndex: 12933
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0x20879F0 Offset: 0x20863F0 VA: 0x1820879F0
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x2096450 Offset: 0x2094E50 VA: 0x182096450 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x2096100 Offset: 0x2094B00 VA: 0x182096100
	internal string AnalyzePattern(string pat) { }
}
