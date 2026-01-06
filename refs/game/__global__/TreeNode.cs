public class TreeNode : MarshalByRefObject, ISerializable, ICloneable // TypeDefIndex: 5662
{
	// Fields
	private TreeView tree_view; // 0x18
	internal TreeNode parent; // 0x20
	private string text; // 0x28
	private int image_index; // 0x30
	private int selected_image_index; // 0x34
	private ContextMenu context_menu; // 0x38
	private ContextMenuStrip context_menu_strip; // 0x40
	private string image_key; // 0x48
	private string selected_image_key; // 0x50
	private int state_image_index; // 0x58
	private string state_image_key; // 0x60
	private string tool_tip_text; // 0x68
	internal TreeNodeCollection nodes; // 0x70
	internal TreeViewAction check_reason; // 0x78
	internal int visible_order; // 0x7C
	internal int width; // 0x80
	internal bool is_expanded; // 0x84
	private bool check; // 0x85
	internal OwnerDrawPropertyBag prop_bag; // 0x88
	private object tag; // 0x90
	private string name; // 0x98
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$map5; // 0x0

	// Properties
	public Color BackColor { get; }
	[Browsable(False)]
	public Rectangle Bounds { get; }
	internal int IndentLevel { get; }
	[DefaultValue(False)]
	public bool Checked { get; set; }
	[DefaultValue(null)]
	public virtual ContextMenu ContextMenu { get; }
	[DefaultValue(null)]
	public virtual ContextMenuStrip ContextMenuStrip { get; }
	[Browsable(False)]
	public TreeNode FirstNode { get; }
	public Color ForeColor { get; }
	[DefaultValue(-1)]
	[RelatedImageList("TreeView.ImageList")]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[RefreshProperties(2)]
	[Localizable(True)]
	[TypeConverter(typeof(TreeViewImageIndexConverter))]
	public int ImageIndex { get; set; }
	[Browsable(False)]
	public bool IsEditing { get; }
	[Browsable(False)]
	public bool IsExpanded { get; }
	[Browsable(False)]
	public bool IsSelected { get; }
	[Browsable(False)]
	public bool IsVisible { get; }
	[Browsable(False)]
	public TreeNode LastNode { get; }
	[Browsable(False)]
	public TreeNode NextNode { get; }
	[Localizable(True)]
	[DefaultValue(null)]
	public Font NodeFont { get; }
	[Browsable(False)]
	[ListBindable(False)]
	public TreeNodeCollection Nodes { get; }
	[Browsable(False)]
	public TreeNode Parent { get; }
	[Browsable(False)]
	public TreeNode PrevNode { get; }
	[DefaultValue(-1)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[RelatedImageList("TreeView.ImageList")]
	[TypeConverter(typeof(TreeViewImageIndexConverter))]
	[RefreshProperties(2)]
	[Localizable(True)]
	public int SelectedImageIndex { get; }
	[DefaultValue(null)]
	[Localizable(False)]
	[TypeConverter(typeof(StringConverter))]
	[Bindable(True)]
	public object Tag { get; set; }
	[Localizable(True)]
	public string Text { get; set; }
	[Localizable(False)]
	[DefaultValue("")]
	public string ToolTipText { get; }
	[Browsable(False)]
	public TreeView TreeView { get; }
	internal bool ArePreviousNodesExpanded { get; }
	internal bool IsRoot { get; }
	public int Index { get; }
	internal Image StateImage { get; }
	internal int Image { get; }

	// Methods

	// RVA: 0x225DA20 Offset: 0x225C420 VA: 0x18225DA20
	internal void .ctor(TreeView tree_view) { }

	// RVA: 0x225DA60 Offset: 0x225C460 VA: 0x18225DA60
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext context) { }

	// RVA: 0x225E190 Offset: 0x225CB90 VA: 0x18225E190
	public void .ctor() { }

	// RVA: 0x225E340 Offset: 0x225CD40 VA: 0x18225E340
	public void .ctor(string text) { }

	// RVA: 0x225E370 Offset: 0x225CD70 VA: 0x18225E370
	public void .ctor(string text, int imageIndex, int selectedImageIndex) { }

	// RVA: 0x225D5B0 Offset: 0x225BFB0 VA: 0x18225D5B0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x225BA50 Offset: 0x225A450 VA: 0x18225BA50 Slot: 8
	public virtual object Clone() { }

	// RVA: 0x225E400 Offset: 0x225CE00 VA: 0x18225E400
	public Color get_BackColor() { }

	// RVA: 0x225E4A0 Offset: 0x225CEA0 VA: 0x18225E4A0
	public Rectangle get_Bounds() { }

	// RVA: 0x225D060 Offset: 0x225BA60 VA: 0x18225D060
	internal int GetY() { }

	// RVA: 0x225CD60 Offset: 0x225B760 VA: 0x18225CD60
	internal int GetX() { }

	// RVA: 0x225CC20 Offset: 0x225B620 VA: 0x18225CC20
	internal int GetLinesX() { }

	// RVA: 0x225CB70 Offset: 0x225B570 VA: 0x18225CB70
	internal int GetImageX() { }

	// RVA: 0x225EB80 Offset: 0x225D580 VA: 0x18225EB80
	internal int get_IndentLevel() { }

	// RVA: 0x4CD070 Offset: 0x4CBA70 VA: 0x1804CD070
	public bool get_Checked() { }

	// RVA: 0x225F890 Offset: 0x225E290 VA: 0x18225F890
	public void set_Checked(bool value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 9
	public virtual ContextMenu get_ContextMenu() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 10
	public virtual ContextMenuStrip get_ContextMenuStrip() { }

	// RVA: 0x225E6D0 Offset: 0x225D0D0 VA: 0x18225E6D0
	public TreeNode get_FirstNode() { }

	// RVA: 0x225E710 Offset: 0x225D110 VA: 0x18225E710
	public Color get_ForeColor() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_ImageIndex() { }

	// RVA: 0x225FA50 Offset: 0x225E450 VA: 0x18225FA50
	public void set_ImageIndex(int value) { }

	// RVA: 0x225ECF0 Offset: 0x225D6F0 VA: 0x18225ECF0
	public bool get_IsEditing() { }

	// RVA: 0x225ED60 Offset: 0x225D760 VA: 0x18225ED60
	public bool get_IsExpanded() { }

	// RVA: 0x225F100 Offset: 0x225DB00 VA: 0x18225F100
	public bool get_IsSelected() { }

	// RVA: 0x225F1F0 Offset: 0x225DBF0 VA: 0x18225F1F0
	public bool get_IsVisible() { }

	// RVA: 0x225F350 Offset: 0x225DD50 VA: 0x18225F350
	public TreeNode get_LastNode() { }

	// RVA: 0x225F380 Offset: 0x225DD80 VA: 0x18225F380
	public TreeNode get_NextNode() { }

	// RVA: 0x225F410 Offset: 0x225DE10 VA: 0x18225F410
	public Font get_NodeFont() { }

	// RVA: 0x225F4E0 Offset: 0x225DEE0 VA: 0x18225F4E0
	public TreeNodeCollection get_Nodes() { }

	// RVA: 0x225F550 Offset: 0x225DF50 VA: 0x18225F550
	public TreeNode get_Parent() { }

	// RVA: 0x225F5D0 Offset: 0x225DFD0 VA: 0x18225F5D0
	public TreeNode get_PrevNode() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_SelectedImageIndex() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public object get_Tag() { }

	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	public void set_Tag(object value) { }

	// RVA: 0x225F7E0 Offset: 0x225E1E0 VA: 0x18225F7E0
	public string get_Text() { }

	// RVA: 0x225FB10 Offset: 0x225E510 VA: 0x18225FB10
	public void set_Text(string value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public string get_ToolTipText() { }

	// RVA: 0x225F830 Offset: 0x225E230 VA: 0x18225F830
	public TreeView get_TreeView() { }

	// RVA: 0x225B9D0 Offset: 0x225A3D0 VA: 0x18225B9D0
	public void BeginEdit() { }

	// RVA: 0x225C0B0 Offset: 0x225AAB0 VA: 0x18225C0B0
	public void Collapse() { }

	// RVA: 0x225C1B0 Offset: 0x225ABB0 VA: 0x18225C1B0
	public void EndEdit(bool cancel) { }

	// RVA: 0x225C9A0 Offset: 0x225B3A0 VA: 0x18225C9A0
	public void Expand() { }

	// RVA: 0x225C590 Offset: 0x225AF90 VA: 0x18225C590
	public void ExpandAll() { }

	// RVA: 0x225C2D0 Offset: 0x225ACD0 VA: 0x18225C2D0
	public void EnsureVisible() { }

	// RVA: 0x225D550 Offset: 0x225BF50 VA: 0x18225D550
	public void Remove() { }

	// RVA: 0x225D9F0 Offset: 0x225C3F0 VA: 0x18225D9F0
	public void Toggle() { }

	// RVA: 0x225D970 Offset: 0x225C370 VA: 0x18225D970 Slot: 3
	public override string ToString() { }

	// RVA: 0x225E3C0 Offset: 0x225CDC0 VA: 0x18225E3C0
	internal bool get_ArePreviousNodesExpanded() { }

	// RVA: 0x225F090 Offset: 0x225DA90 VA: 0x18225F090
	internal bool get_IsRoot() { }

	// RVA: 0x225EC80 Offset: 0x225D680 VA: 0x18225EC80
	public int get_Index() { }

	// RVA: 0x225C9B0 Offset: 0x225B3B0 VA: 0x18225C9B0
	private void Expand(bool byInternal) { }

	// RVA: 0x225BE40 Offset: 0x225A840 VA: 0x18225BE40
	private void CollapseInternal(bool byInternal) { }

	// RVA: 0x225C0C0 Offset: 0x225AAC0 VA: 0x18225C0C0
	private int CountToNext() { }

	// RVA: 0x225D200 Offset: 0x225BC00 VA: 0x18225D200
	private bool HasFocusInChildren() { }

	// RVA: 0x225C700 Offset: 0x225B100 VA: 0x18225C700
	private void ExpandRecursive(TreeNode node) { }

	// RVA: 0x225C6B0 Offset: 0x225B0B0 VA: 0x18225C6B0
	private void ExpandParentRecursive(TreeNode node) { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void SetNodes(TreeNodeCollection nodes) { }

	// RVA: 0x225D4C0 Offset: 0x225BEC0 VA: 0x18225D4C0
	internal void Invalidate() { }

	// RVA: 0x1663D70 Offset: 0x1662770 VA: 0x181663D70
	internal void InvalidateWidth() { }

	// RVA: 0x225F660 Offset: 0x225E060 VA: 0x18225F660
	internal Image get_StateImage() { }

	// RVA: 0x225E820 Offset: 0x225D220 VA: 0x18225E820
	internal int get_Image() { }
}
