internal class UndoManager // TypeDefIndex: 5587
{
	// Fields
	private Document document; // 0x10
	private Stack undo_actions; // 0x18
	private Stack redo_actions; // 0x20
	private bool locked; // 0x28

	// Properties
	internal bool CanUndo { get; }

	// Methods

	// RVA: 0x222C9F0 Offset: 0x222B3F0 VA: 0x18222C9F0
	internal void .ctor(Document document) { }

	// RVA: 0x222CAA0 Offset: 0x222B4A0 VA: 0x18222CAA0
	internal bool get_CanUndo() { }

	// RVA: 0x222C600 Offset: 0x222B000 VA: 0x18222C600
	internal bool Undo() { }

	// RVA: 0x222B880 Offset: 0x222A280 VA: 0x18222B880
	public void BeginUserAction(string name) { }

	// RVA: 0x222BCC0 Offset: 0x222A6C0 VA: 0x18222BCC0
	public void EndUserAction() { }

	// RVA: 0x222C1E0 Offset: 0x222ABE0 VA: 0x18222C1E0
	public void RecordDeleteString(Line start_line, int start_pos, Line end_line, int end_pos) { }

	// RVA: 0x222C300 Offset: 0x222AD00 VA: 0x18222C300
	public void RecordInsertString(Line line, int pos, string str) { }

	// RVA: 0x222C410 Offset: 0x222AE10 VA: 0x18222C410
	public void RecordTyping(Line line, int pos, char ch) { }

	// RVA: 0x222B940 Offset: 0x222A340 VA: 0x18222B940
	public Line Duplicate(Line start_line, int start_pos, Line end_line, int end_pos) { }

	// RVA: 0x222BD50 Offset: 0x222A750 VA: 0x18222BD50
	internal void Insert(Line line, int pos, Line insert, bool select) { }
}
