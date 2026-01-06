internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 12969
{
	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113C30 Offset: 0x1112630 VA: 0x181113C30
	|-RBTree<int>..ctor
	|
	|-RVA: 0x1122A70 Offset: 0x1121470 VA: 0x181122A70
	|-RBTree<object>..ctor
	|
	|-RVA: 0x1122A20 Offset: 0x1121420 VA: 0x181122A20
	|-RBTree<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110EAF0 Offset: 0x110D4F0 VA: 0x18110EAF0
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x1117FC0 Offset: 0x11169C0 VA: 0x181117FC0
	|-RBTree<object>.InitTree
	|
	|-RVA: 0x1117DD0 Offset: 0x11167D0 VA: 0x181117DD0
	|-RBTree<__Il2CppFullySharedGenericType>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DCC0 Offset: 0x110C6C0 VA: 0x18110DCC0
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	|
	|-RVA: 0x1115FF0 Offset: 0x11149F0 VA: 0x181115FF0
	|-RBTree<__Il2CppFullySharedGenericType>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CCB0 Offset: 0x110B6B0 VA: 0x18110CCB0
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x1113F10 Offset: 0x1112910 VA: 0x181113F10
	|-RBTree<object>.AllocPage
	|
	|-RVA: 0x11141B0 Offset: 0x1112BB0 VA: 0x1811141B0
	|-RBTree<__Il2CppFullySharedGenericType>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F740 Offset: 0x110E140 VA: 0x18110F740
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	|
	|-RVA: 0x1119710 Offset: 0x1118110 VA: 0x181119710
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F6E0 Offset: 0x110E0E0 VA: 0x18110F6E0
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	|
	|-RVA: 0x1119650 Offset: 0x1118050 VA: 0x181119650
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E340 Offset: 0x110CD40 VA: 0x18110E340
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	|-RBTree<__Il2CppFullySharedGenericType>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DB40 Offset: 0x110C540 VA: 0x18110DB40
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x1115CD0 Offset: 0x11146D0 VA: 0x181115CD0
	|-RBTree<object>.FreeNode
	|
	|-RVA: 0x1115E50 Offset: 0x1114850 VA: 0x181115E50
	|-RBTree<__Il2CppFullySharedGenericType>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E1A0 Offset: 0x110CBA0 VA: 0x18110E1A0
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x1116940 Offset: 0x1115340 VA: 0x181116940
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113CE0 Offset: 0x11126E0 VA: 0x181113CE0
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	|-RBTree<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113CF0 Offset: 0x11126F0 VA: 0x181113CF0
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	|-RBTree<__Il2CppFullySharedGenericType>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E3B0 Offset: 0x110CDB0 VA: 0x18110E3B0
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x1116ED0 Offset: 0x11158D0 VA: 0x181116ED0
	|-RBTree<object>.GetNewNode
	|
	|-RVA: 0x1116AF0 Offset: 0x11154F0 VA: 0x181116AF0
	|-RBTree<__Il2CppFullySharedGenericType>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11139E0 Offset: 0x11123E0 VA: 0x1811139E0
	|-RBTree<int>.Successor
	|
	|-RVA: 0x1122470 Offset: 0x1120E70 VA: 0x181122470
	|-RBTree<object>.Successor
	|
	|-RVA: 0x1122350 Offset: 0x1120D50 VA: 0x181122350
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113890 Offset: 0x1112290 VA: 0x181113890
	|-RBTree<int>.Successor
	|
	|-RVA: 0x1122200 Offset: 0x1120C00 VA: 0x181122200
	|-RBTree<object>.Successor
	|
	|-RVA: 0x11225B0 Offset: 0x1120FB0 VA: 0x1811225B0
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F7A0 Offset: 0x110E1A0 VA: 0x18110F7A0
	|-RBTree<int>.Minimum
	|
	|-RVA: 0x11197D0 Offset: 0x11181D0 VA: 0x1811197D0
	|-RBTree<object>.Minimum
	|
	|-RVA: 0x1119860 Offset: 0x1118260 VA: 0x181119860
	|-RBTree<__Il2CppFullySharedGenericType>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110EE00 Offset: 0x110D800 VA: 0x18110EE00
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x1118620 Offset: 0x1117020 VA: 0x181118620
	|-RBTree<object>.LeftRotate
	|
	|-RVA: 0x1118E70 Offset: 0x1117870 VA: 0x181118E70
	|-RBTree<__Il2CppFullySharedGenericType>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112BB0 Offset: 0x11115B0 VA: 0x181112BB0
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x1120550 Offset: 0x111EF50 VA: 0x181120550
	|-RBTree<object>.RightRotate
	|
	|-RVA: 0x1120DA0 Offset: 0x111F7A0 VA: 0x181120DA0
	|-RBTree<__Il2CppFullySharedGenericType>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111580 Offset: 0x110FF80 VA: 0x181111580
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x111ECC0 Offset: 0x111D6C0 VA: 0x18111ECC0
	|-RBTree<object>.RBInsert
	|
	|-RVA: 0x111D520 Offset: 0x111BF20 VA: 0x18111D520
	|-RBTree<__Il2CppFullySharedGenericType>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113B20 Offset: 0x1112520 VA: 0x181113B20
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x11226E0 Offset: 0x11210E0 VA: 0x1811226E0
	|-RBTree<object>.UpdateNodeKey
	|
	|-RVA: 0x11227D0 Offset: 0x11211D0 VA: 0x1811227D0
	|-RBTree<__Il2CppFullySharedGenericType>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DA80 Offset: 0x110C480 VA: 0x18110DA80
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x1115C10 Offset: 0x1114610 VA: 0x181115C10
	|-RBTree<object>.DeleteByIndex
	|
	|-RVA: 0x1115AE0 Offset: 0x11144E0 VA: 0x181115AE0
	|-RBTree<__Il2CppFullySharedGenericType>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111550 Offset: 0x110FF50 VA: 0x181111550
	|-RBTree<int>.RBDelete
	|
	|-RVA: 0x111D4F0 Offset: 0x111BEF0 VA: 0x18111D4F0
	|-RBTree<object>.RBDelete
	|
	|-RVA: 0x111D4C0 Offset: 0x111BEC0 VA: 0x18111D4C0
	|-RBTree<__Il2CppFullySharedGenericType>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110200 Offset: 0x110EC00 VA: 0x181110200
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x111AFC0 Offset: 0x11199C0 VA: 0x18111AFC0
	|-RBTree<object>.RBDeleteX
	|
	|-RVA: 0x111C300 Offset: 0x111AD00 VA: 0x18111C300
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F8F0 Offset: 0x110E2F0 VA: 0x18110F8F0
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x111A6B0 Offset: 0x11190B0 VA: 0x18111A6B0
	|-RBTree<object>.RBDeleteFixup
	|
	|-RVA: 0x1119AD0 Offset: 0x11184D0 VA: 0x181119AD0
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113490 Offset: 0x1111E90 VA: 0x181113490
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x11217E0 Offset: 0x11201E0 VA: 0x1811217E0
	|-RBTree<object>.SearchSubTree
	|
	|-RVA: 0x1121580 Offset: 0x111FF80 VA: 0x181121580
	|-RBTree<__Il2CppFullySharedGenericType>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113D00 Offset: 0x1112700 VA: 0x181113D00
	|-RBTree<int>.get_Item
	|
	|-RVA: 0x1122BB0 Offset: 0x11215B0 VA: 0x181122BB0
	|-RBTree<object>.get_Item
	|
	|-RVA: 0x1122C20 Offset: 0x1121620 VA: 0x181122C20
	|-RBTree<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E6B0 Offset: 0x110D0B0 VA: 0x18110E6B0
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x11176B0 Offset: 0x11160B0 VA: 0x1811176B0
	|-RBTree<object>.GetNodeByKey
	|
	|-RVA: 0x11172D0 Offset: 0x1115CD0 VA: 0x1811172D0
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DDE0 Offset: 0x110C7E0 VA: 0x18110DDE0
	|-RBTree<int>.GetIndexByKey
	|
	|-RVA: 0x11161B0 Offset: 0x1114BB0 VA: 0x1811161B0
	|-RBTree<object>.GetIndexByKey
	|
	|-RVA: 0x11162D0 Offset: 0x1114CD0 VA: 0x1811162D0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DFC0 Offset: 0x110C9C0 VA: 0x18110DFC0
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x1116580 Offset: 0x1114F80 VA: 0x181116580
	|-RBTree<object>.GetIndexByNode
	|
	|-RVA: 0x1116760 Offset: 0x1115160 VA: 0x181116760
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DF00 Offset: 0x110C900 VA: 0x18110DF00
	|-RBTree<int>.GetIndexByNodePath
	|
	|-RVA: 0x11163F0 Offset: 0x1114DF0 VA: 0x1811163F0
	|-RBTree<object>.GetIndexByNodePath
	|
	|-RVA: 0x11164B0 Offset: 0x1114EB0 VA: 0x1811164B0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CF80 Offset: 0x110B980 VA: 0x18110CF80
	|-RBTree<int>.ComputeIndexByNode
	|
	|-RVA: 0x1114610 Offset: 0x1113010 VA: 0x181114610
	|-RBTree<object>.ComputeIndexByNode
	|
	|-RVA: 0x11144D0 Offset: 0x1112ED0 VA: 0x1811144D0
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110D140 Offset: 0x110BB40 VA: 0x18110D140
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x11147C0 Offset: 0x11131C0 VA: 0x1811147C0
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x11149F0 Offset: 0x11133F0 VA: 0x1811149F0
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E5D0 Offset: 0x110CFD0 VA: 0x18110E5D0
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x11171F0 Offset: 0x1115BF0 VA: 0x1811171F0
	|-RBTree<object>.GetNodeByIndex
	|
	|-RVA: 0x1117110 Offset: 0x1115B10 VA: 0x181117110
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110D480 Offset: 0x110BE80 VA: 0x18110D480
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x1114F00 Offset: 0x1113900 VA: 0x181114F00
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x1114CB0 Offset: 0x11136B0 VA: 0x181114CB0
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110D370 Offset: 0x110BD70 VA: 0x18110D370
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x1114BA0 Offset: 0x11135A0 VA: 0x181114BA0
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x1115170 Offset: 0x1113B70 VA: 0x181115170
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CC30 Offset: 0x110B630 VA: 0x18110CC30
	|-RBTree<int>.Insert
	|
	|-RVA: 0x1113E90 Offset: 0x1112890 VA: 0x181113E90
	|-RBTree<object>.Insert
	|
	|-RVA: 0x1113D70 Offset: 0x1112770 VA: 0x181113D70
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CC30 Offset: 0x110B630 VA: 0x18110CC30
	|-RBTree<int>.Add
	|
	|-RVA: 0x1113E90 Offset: 0x1112890 VA: 0x181113E90
	|-RBTree<object>.Add
	|
	|-RVA: 0x1113D70 Offset: 0x1112770 VA: 0x181113D70
	|-RBTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DD50 Offset: 0x110C750 VA: 0x18110DD50
	|-RBTree<int>.GetEnumerator
	|
	|-RVA: 0x1116090 Offset: 0x1114A90 VA: 0x181116090
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x1116100 Offset: 0x1114B00 VA: 0x181116100
	|-RBTree<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E970 Offset: 0x110D370 VA: 0x18110E970
	|-RBTree<int>.IndexOf
	|
	|-RVA: 0x1117CA0 Offset: 0x11166A0 VA: 0x181117CA0
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x11179A0 Offset: 0x11163A0 VA: 0x1811179A0
	|-RBTree<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110ED00 Offset: 0x110D700 VA: 0x18110ED00
	|-RBTree<int>.Insert
	|
	|-RVA: 0x1118300 Offset: 0x1116D00 VA: 0x181118300
	|-RBTree<object>.Insert
	|
	|-RVA: 0x11183A0 Offset: 0x1116DA0 VA: 0x1811183A0
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110EC60 Offset: 0x110D660 VA: 0x18110EC60
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x1118260 Offset: 0x1116C60 VA: 0x181118260
	|-RBTree<object>.InsertAt
	|
	|-RVA: 0x1118130 Offset: 0x1116B30 VA: 0x181118130
	|-RBTree<__Il2CppFullySharedGenericType>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112B00 Offset: 0x1111500 VA: 0x181112B00
	|-RBTree<int>.RemoveAt
	|
	|-RVA: 0x11204A0 Offset: 0x111EEA0 VA: 0x1811204A0
	|-RBTree<object>.RemoveAt
	|
	|-RVA: 0x11203E0 Offset: 0x111EDE0 VA: 0x1811203E0
	|-RBTree<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CF50 Offset: 0x110B950 VA: 0x18110CF50
	|-RBTree<int>.Clear
	|
	|-RVA: 0x1114470 Offset: 0x1112E70 VA: 0x181114470
	|-RBTree<object>.Clear
	|
	|-RVA: 0x11144A0 Offset: 0x1112EA0 VA: 0x1811144A0
	|-RBTree<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110D6F0 Offset: 0x110C0F0 VA: 0x18110D6F0
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x1115250 Offset: 0x1113C50 VA: 0x181115250
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1115580 Offset: 0x1113F80 VA: 0x181115580
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110D8A0 Offset: 0x110C2A0 VA: 0x18110D8A0
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x11153D0 Offset: 0x1113DD0 VA: 0x1811153D0
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1115790 Offset: 0x1114190 VA: 0x181115790
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113770 Offset: 0x1112170 VA: 0x181113770
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x1121EE0 Offset: 0x11208E0 VA: 0x181121EE0
	|-RBTree<object>.SetRight
	|
	|-RVA: 0x1121F30 Offset: 0x1120930 VA: 0x181121F30
	|-RBTree<__Il2CppFullySharedGenericType>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113650 Offset: 0x1112050 VA: 0x181113650
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x1121C60 Offset: 0x1120660 VA: 0x181121C60
	|-RBTree<object>.SetLeft
	|
	|-RVA: 0x1121BA0 Offset: 0x11205A0 VA: 0x181121BA0
	|-RBTree<__Il2CppFullySharedGenericType>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113710 Offset: 0x1112110 VA: 0x181113710
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x1121DD0 Offset: 0x11207D0 VA: 0x181121DD0
	|-RBTree<object>.SetParent
	|
	|-RVA: 0x1121E20 Offset: 0x1120820 VA: 0x181121E20
	|-RBTree<__Il2CppFullySharedGenericType>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113590 Offset: 0x1111F90 VA: 0x181113590
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x11219B0 Offset: 0x11203B0 VA: 0x1811219B0
	|-RBTree<object>.SetColor
	|
	|-RVA: 0x11218E0 Offset: 0x11202E0 VA: 0x1811218E0
	|-RBTree<__Il2CppFullySharedGenericType>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11135F0 Offset: 0x1111FF0 VA: 0x1811135F0
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x1121B30 Offset: 0x1120530 VA: 0x181121B30
	|-RBTree<object>.SetKey
	|
	|-RVA: 0x1121A00 Offset: 0x1120400 VA: 0x181121A00
	|-RBTree<__Il2CppFullySharedGenericType>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11136B0 Offset: 0x11120B0 VA: 0x1811136B0
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x1121CB0 Offset: 0x11206B0 VA: 0x181121CB0
	|-RBTree<object>.SetNext
	|
	|-RVA: 0x1121D00 Offset: 0x1120700 VA: 0x181121D00
	|-RBTree<__Il2CppFullySharedGenericType>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11137D0 Offset: 0x11121D0 VA: 0x1811137D0
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x1121FF0 Offset: 0x11209F0 VA: 0x181121FF0
	|-RBTree<object>.SetSubTreeSize
	|
	|-RVA: 0x1122040 Offset: 0x1120A40 VA: 0x181122040
	|-RBTree<__Il2CppFullySharedGenericType>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E910 Offset: 0x110D310 VA: 0x18110E910
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x1117950 Offset: 0x1116350 VA: 0x181117950
	|-RBTree<object>.IncreaseSize
	|
	|-RVA: 0x11178C0 Offset: 0x11162C0 VA: 0x1811178C0
	|-RBTree<__Il2CppFullySharedGenericType>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112940 Offset: 0x1111340 VA: 0x181112940
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x1120050 Offset: 0x111EA50 VA: 0x181120050
	|-RBTree<object>.RecomputeSize
	|
	|-RVA: 0x1120210 Offset: 0x111EC10 VA: 0x181120210
	|-RBTree<__Il2CppFullySharedGenericType>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DA20 Offset: 0x110C420 VA: 0x18110DA20
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x1115A00 Offset: 0x1114400 VA: 0x181115A00
	|-RBTree<object>.DecreaseSize
	|
	|-RVA: 0x1115A50 Offset: 0x1114450 VA: 0x181115A50
	|-RBTree<__Il2CppFullySharedGenericType>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113430 Offset: 0x1111E30 VA: 0x181113430
	|-RBTree<int>.Right
	|
	|-RVA: 0x1121520 Offset: 0x111FF20 VA: 0x181121520
	|-RBTree<object>.Right
	|
	|-RVA: 0x11214A0 Offset: 0x111FEA0 VA: 0x1811214A0
	|-RBTree<__Il2CppFullySharedGenericType>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F680 Offset: 0x110E080 VA: 0x18110F680
	|-RBTree<int>.Left
	|
	|-RVA: 0x11195F0 Offset: 0x1117FF0 VA: 0x1811195F0
	|-RBTree<object>.Left
	|
	|-RVA: 0x1119570 Offset: 0x1117F70 VA: 0x181119570
	|-RBTree<__Il2CppFullySharedGenericType>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F890 Offset: 0x110E290 VA: 0x18110F890
	|-RBTree<int>.Parent
	|
	|-RVA: 0x1119A70 Offset: 0x1118470 VA: 0x181119A70
	|-RBTree<object>.Parent
	|
	|-RVA: 0x11199F0 Offset: 0x11183F0 VA: 0x1811199F0
	|-RBTree<__Il2CppFullySharedGenericType>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113C80 Offset: 0x1112680 VA: 0x181113C80
	|-RBTree<int>.color
	|
	|-RVA: 0x1122B50 Offset: 0x1121550 VA: 0x181122B50
	|-RBTree<object>.color
	|
	|-RVA: 0x1122AC0 Offset: 0x11214C0 VA: 0x181122AC0
	|-RBTree<__Il2CppFullySharedGenericType>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F830 Offset: 0x110E230 VA: 0x18110F830
	|-RBTree<int>.Next
	|
	|-RVA: 0x1119900 Offset: 0x1118300 VA: 0x181119900
	|-RBTree<object>.Next
	|
	|-RVA: 0x1119960 Offset: 0x1118360 VA: 0x181119960
	|-RBTree<__Il2CppFullySharedGenericType>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113830 Offset: 0x1112230 VA: 0x181113830
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x1122110 Offset: 0x1120B10 VA: 0x181122110
	|-RBTree<object>.SubTreeSize
	|
	|-RVA: 0x1122170 Offset: 0x1120B70 VA: 0x181122170
	|-RBTree<__Il2CppFullySharedGenericType>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110EDA0 Offset: 0x110D7A0 VA: 0x18110EDA0
	|-RBTree<int>.Key
	|
	|-RVA: 0x11185C0 Offset: 0x1116FC0 VA: 0x1811185C0
	|-RBTree<object>.Key
	|
	|-RVA: 0x11184B0 Offset: 0x1116EB0 VA: 0x1811184B0
	|-RBTree<__Il2CppFullySharedGenericType>.Key
	*/
}
