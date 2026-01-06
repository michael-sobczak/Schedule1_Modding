public static class Enumerable // TypeDefIndex: 15060
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE98030 Offset: 0xE96A30 VA: 0x180E98030
	|-Enumerable.Where<KeyValuePair<object, bool>>
	|-Enumerable.Where<KeyValuePair<object, object>>
	|-Enumerable.Where<Connection>
	|-Enumerable.Where<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xE98A60 Offset: 0xE97460 VA: 0x180E98A60
	|-Enumerable.Where<Int32Enum>
	|-Enumerable.Where<object>
	|
	|-RVA: 0xE986F0 Offset: 0xE970F0 VA: 0x180E986F0
	|-Enumerable.Where<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE98390 Offset: 0xE96D90 VA: 0x180E98390
	|-Enumerable.Where<InputControlLayout.ControlItem>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE91510 Offset: 0xE8FF10 VA: 0x180E91510
	|-Enumerable.Select<KeyValuePair<object, bool>, object>
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|-Enumerable.Select<KeyValuePair<object, JsonParser.JsonValue>, object>
	|-Enumerable.Select<double, float>
	|-Enumerable.Select<int, int>
	|-Enumerable.Select<InternedString, object>
	|-Enumerable.Select<Label, object>
	|-Enumerable.Select<NameAndParameters, object>
	|-Enumerable.Select<NamedValue, object>
	|-Enumerable.Select<object, int>
	|-Enumerable.Select<object, object>
	|-Enumerable.Select<object, float>
	|-Enumerable.Select<StyleSelectorPart, object>
	|-Enumerable.Select<Substring, object>
	|-Enumerable.Select<Vector2, Vector2>
	|-Enumerable.Select<Vector3, float>
	|-Enumerable.Select<JsonParser.JsonValue, object>
	|
	|-RVA: 0xE91190 Offset: 0xE8FB90 VA: 0x180E91190
	|-Enumerable.Select<Color32, Color>
	|-Enumerable.Select<ContourVertex, Color>
	|-Enumerable.Select<ContourVertex, Vector3>
	|-Enumerable.Select<object, InternedString>
	|
	|-RVA: 0xE91890 Offset: 0xE90290 VA: 0x180E91890
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE91C20 Offset: 0xE90620 VA: 0x180E91C20
	|-Enumerable.Select<InputTransformSpots.TransformSpot, CGSpot>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE869A0 Offset: 0xE853A0 VA: 0x180E869A0
	|-Enumerable.CombinePredicates<KeyValuePair<object, bool>>
	|-Enumerable.CombinePredicates<KeyValuePair<object, object>>
	|-Enumerable.CombinePredicates<Color>
	|-Enumerable.CombinePredicates<Connection>
	|-Enumerable.CombinePredicates<InternedString>
	|-Enumerable.CombinePredicates<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xE868C0 Offset: 0xE852C0 VA: 0x180E868C0
	|-Enumerable.CombinePredicates<CGSpot>
	|
	|-RVA: 0xE86A80 Offset: 0xE85480 VA: 0x180E86A80
	|-Enumerable.CombinePredicates<int>
	|-Enumerable.CombinePredicates<Int32Enum>
	|
	|-RVA: 0xE86B60 Offset: 0xE85560 VA: 0x180E86B60
	|-Enumerable.CombinePredicates<object>
	|
	|-RVA: 0xE86C40 Offset: 0xE85640 VA: 0x180E86C40
	|-Enumerable.CombinePredicates<float>
	|
	|-RVA: 0xE87320 Offset: 0xE85D20 VA: 0x180E87320
	|-Enumerable.CombinePredicates<Vector2>
	|
	|-RVA: 0xE87400 Offset: 0xE85E00 VA: 0x180E87400
	|-Enumerable.CombinePredicates<Vector3>
	|
	|-RVA: 0xE87240 Offset: 0xE85C40 VA: 0x180E87240
	|-Enumerable.CombinePredicates<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE87160 Offset: 0xE85B60 VA: 0x180E87160
	|-Enumerable.CombinePredicates<InputControlLayout.ControlItem>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE87780 Offset: 0xE86180 VA: 0x180E87780
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, int>
	|-Enumerable.CombineSelectors<InternedString, object, int>
	|-Enumerable.CombineSelectors<Substring, object, int>
	|
	|-RVA: 0xE87860 Offset: 0xE86260 VA: 0x180E87860
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, InternedString>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, InternedString>
	|-Enumerable.CombineSelectors<InternedString, object, InternedString>
	|-Enumerable.CombineSelectors<Substring, object, InternedString>
	|
	|-RVA: 0xE87940 Offset: 0xE86340 VA: 0x180E87940
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|-Enumerable.CombineSelectors<InternedString, object, object>
	|-Enumerable.CombineSelectors<Substring, object, object>
	|
	|-RVA: 0xE87A20 Offset: 0xE86420 VA: 0x180E87A20
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, float>
	|-Enumerable.CombineSelectors<InternedString, object, float>
	|-Enumerable.CombineSelectors<Substring, object, float>
	|
	|-RVA: 0xE87E80 Offset: 0xE86880 VA: 0x180E87E80
	|-Enumerable.CombineSelectors<KeyValuePair<object, JsonParser.JsonValue>, object, int>
	|
	|-RVA: 0xE87F60 Offset: 0xE86960 VA: 0x180E87F60
	|-Enumerable.CombineSelectors<KeyValuePair<object, JsonParser.JsonValue>, object, InternedString>
	|
	|-RVA: 0xE88040 Offset: 0xE86A40 VA: 0x180E88040
	|-Enumerable.CombineSelectors<KeyValuePair<object, JsonParser.JsonValue>, object, object>
	|
	|-RVA: 0xE88120 Offset: 0xE86B20 VA: 0x180E88120
	|-Enumerable.CombineSelectors<KeyValuePair<object, JsonParser.JsonValue>, object, float>
	|
	|-RVA: 0xE874E0 Offset: 0xE85EE0 VA: 0x180E874E0
	|-Enumerable.CombineSelectors<ContourVertex, Vector3, float>
	|-Enumerable.CombineSelectors<NameAndParameters, object, float>
	|-Enumerable.CombineSelectors<NamedValue, object, float>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, float>
	|
	|-RVA: 0xE876A0 Offset: 0xE860A0 VA: 0x180E876A0
	|-Enumerable.CombineSelectors<int, int, int>
	|
	|-RVA: 0xE88200 Offset: 0xE86C00 VA: 0x180E88200
	|-Enumerable.CombineSelectors<Label, object, int>
	|
	|-RVA: 0xE882E0 Offset: 0xE86CE0 VA: 0x180E882E0
	|-Enumerable.CombineSelectors<Label, object, InternedString>
	|
	|-RVA: 0xE883C0 Offset: 0xE86DC0 VA: 0x180E883C0
	|-Enumerable.CombineSelectors<Label, object, object>
	|
	|-RVA: 0xE884A0 Offset: 0xE86EA0 VA: 0x180E884A0
	|-Enumerable.CombineSelectors<Label, object, float>
	|
	|-RVA: 0xE88580 Offset: 0xE86F80 VA: 0x180E88580
	|-Enumerable.CombineSelectors<NameAndParameters, object, int>
	|-Enumerable.CombineSelectors<NamedValue, object, int>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, int>
	|
	|-RVA: 0xE88660 Offset: 0xE87060 VA: 0x180E88660
	|-Enumerable.CombineSelectors<NameAndParameters, object, InternedString>
	|-Enumerable.CombineSelectors<NamedValue, object, InternedString>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, InternedString>
	|
	|-RVA: 0xE88740 Offset: 0xE87140 VA: 0x180E88740
	|-Enumerable.CombineSelectors<NameAndParameters, object, object>
	|-Enumerable.CombineSelectors<NamedValue, object, object>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, object>
	|
	|-RVA: 0xE88820 Offset: 0xE87220 VA: 0x180E88820
	|-Enumerable.CombineSelectors<object, int, int>
	|-Enumerable.CombineSelectors<object, object, int>
	|
	|-RVA: 0xE88900 Offset: 0xE87300 VA: 0x180E88900
	|-Enumerable.CombineSelectors<object, InternedString, object>
	|-Enumerable.CombineSelectors<object, object, object>
	|
	|-RVA: 0xE889E0 Offset: 0xE873E0 VA: 0x180E889E0
	|-Enumerable.CombineSelectors<object, object, InternedString>
	|
	|-RVA: 0xE88AC0 Offset: 0xE874C0 VA: 0x180E88AC0
	|-Enumerable.CombineSelectors<object, object, float>
	|
	|-RVA: 0xE88BA0 Offset: 0xE875A0 VA: 0x180E88BA0
	|-Enumerable.CombineSelectors<Vector2, Vector2, Vector2>
	|
	|-RVA: 0xE875C0 Offset: 0xE85FC0 VA: 0x180E875C0
	|-Enumerable.CombineSelectors<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE87B00 Offset: 0xE86500 VA: 0x180E87B00
	|-Enumerable.CombineSelectors<JsonParser.JsonValue, object, int>
	|
	|-RVA: 0xE87BE0 Offset: 0xE865E0 VA: 0x180E87BE0
	|-Enumerable.CombineSelectors<JsonParser.JsonValue, object, InternedString>
	|
	|-RVA: 0xE87CC0 Offset: 0xE866C0 VA: 0x180E87CC0
	|-Enumerable.CombineSelectors<JsonParser.JsonValue, object, object>
	|
	|-RVA: 0xE87DA0 Offset: 0xE867A0 VA: 0x180E87DA0
	|-Enumerable.CombineSelectors<JsonParser.JsonValue, object, float>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE91070 Offset: 0xE8FA70 VA: 0x180E91070
	|-Enumerable.SelectMany<object, object>
	|
	|-RVA: 0xE90FD0 Offset: 0xE8F9D0 VA: 0x180E90FD0
	|-Enumerable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectManyIterator>d__17<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90F20 Offset: 0xE8F920 VA: 0x180E90F20
	|-Enumerable.SelectManyIterator<object, object>
	|
	|-RVA: 0xE90E00 Offset: 0xE8F800 VA: 0x180E90E00
	|-Enumerable.SelectManyIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90B90 Offset: 0xE8F590 VA: 0x180E90B90
	|-Enumerable.OrderBy<ValueTuple<object, object>, object>
	|-Enumerable.OrderBy<object, object>
	|
	|-RVA: 0xE90820 Offset: 0xE8F220 VA: 0x180E90820
	|-Enumerable.OrderBy<GlyphPairAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.OrderBy<object, uint>
	|
	|-RVA: 0xE909E0 Offset: 0xE8F3E0 VA: 0x180E909E0
	|-Enumerable.OrderBy<Label, int>
	|-Enumerable.OrderBy<object, int>
	|
	|-RVA: 0xE90B00 Offset: 0xE8F500 VA: 0x180E90B00
	|-Enumerable.OrderBy<object, byte>
	|
	|-RVA: 0xE90A70 Offset: 0xE8F470 VA: 0x180E90A70
	|-Enumerable.OrderBy<object, float>
	|-Enumerable.OrderBy<RaycastHit, float>
	|
	|-RVA: 0xE90950 Offset: 0xE8F350 VA: 0x180E90950
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90C20 Offset: 0xE8F620 VA: 0x180E90C20
	|-Enumerable.OrderBy<object, object>
	|
	|-RVA: 0xE908B0 Offset: 0xE8F2B0 VA: 0x180E908B0
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90550 Offset: 0xE8EF50 VA: 0x180E90550
	|-Enumerable.OrderByDescending<CoordinateFootprintTilePair, int>
	|-Enumerable.OrderByDescending<CoordinateStorageFootprintTilePair, int>
	|-Enumerable.OrderByDescending<object, int>
	|
	|-RVA: 0xE90670 Offset: 0xE8F070 VA: 0x180E90670
	|-Enumerable.OrderByDescending<Int32Enum, float>
	|-Enumerable.OrderByDescending<object, float>
	|
	|-RVA: 0xE90700 Offset: 0xE8F100 VA: 0x180E90700
	|-Enumerable.OrderByDescending<object, byte>
	|
	|-RVA: 0xE90790 Offset: 0xE8F190 VA: 0x180E90790
	|-Enumerable.OrderByDescending<object, Int32Enum>
	|
	|-RVA: 0xE905E0 Offset: 0xE8EFE0 VA: 0x180E905E0
	|-Enumerable.OrderByDescending<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94ED0 Offset: 0xE938D0 VA: 0x180E94ED0
	|-Enumerable.ThenBy<GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, int>
	|-Enumerable.ThenBy<object, uint>
	|-Enumerable.ThenBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8E650 Offset: 0xE8D050 VA: 0x180E8E650
	|-Enumerable.GroupBy<object, int>
	|-Enumerable.GroupBy<object, object>
	|
	|-RVA: 0xE8E5A0 Offset: 0xE8CFA0 VA: 0x180E8E5A0
	|-Enumerable.GroupBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8ACC0 Offset: 0xE896C0 VA: 0x180E8ACC0
	|-Enumerable.Distinct<int>
	|
	|-RVA: 0xE8ADA0 Offset: 0xE897A0 VA: 0x180E8ADA0
	|-Enumerable.Distinct<object>
	|
	|-RVA: 0xE8AC50 Offset: 0xE89650 VA: 0x180E8AC50
	|-Enumerable.Distinct<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<DistinctIterator>d__68<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8AAF0 Offset: 0xE894F0 VA: 0x180E8AAF0
	|-Enumerable.DistinctIterator<int>
	|
	|-RVA: 0xE8ABA0 Offset: 0xE895A0 VA: 0x180E8ABA0
	|-Enumerable.DistinctIterator<object>
	|
	|-RVA: 0xE8A9D0 Offset: 0xE893D0 VA: 0x180E8A9D0
	|-Enumerable.DistinctIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97D30 Offset: 0xE96730 VA: 0x180E97D30
	|-Enumerable.Union<char>
	|
	|-RVA: 0xE97F00 Offset: 0xE96900 VA: 0x180E97F00
	|-Enumerable.Union<object>
	|
	|-RVA: 0xE97E60 Offset: 0xE96860 VA: 0x180E97E60
	|-Enumerable.Union<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<UnionIterator>d__71<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97A30 Offset: 0xE96430 VA: 0x180E97A30
	|-Enumerable.UnionIterator<char>
	|
	|-RVA: 0xE97C60 Offset: 0xE96660 VA: 0x180E97C60
	|-Enumerable.UnionIterator<object>
	|
	|-RVA: 0xE97B00 Offset: 0xE96500 VA: 0x180E97B00
	|-Enumerable.UnionIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90D30 Offset: 0xE8F730 VA: 0x180E90D30
	|-Enumerable.Reverse<object>
	|
	|-RVA: 0xE90CC0 Offset: 0xE8F6C0 VA: 0x180E90CC0
	|-Enumerable.Reverse<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ReverseIterator>d__79<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE864D0 Offset: 0xE84ED0 VA: 0x180E864D0
	|-Enumerable.ReverseIterator<object>
	|
	|-RVA: 0xE86380 Offset: 0xE84D80 VA: 0x180E86380
	|-Enumerable.ReverseIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE91FA0 Offset: 0xE909A0 VA: 0x180E91FA0
	|-Enumerable.SequenceEqual<byte>
	|
	|-RVA: 0xE92C50 Offset: 0xE91650 VA: 0x180E92C50
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0xE92870 Offset: 0xE91270 VA: 0x180E92870
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE931B0 Offset: 0xE91BB0 VA: 0x180E931B0
	|-Enumerable.SequenceEqual<MultiColumnCollectionHeader.SortedColumnState>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE91FF0 Offset: 0xE909F0 VA: 0x180E91FF0
	|-Enumerable.SequenceEqual<byte>
	|
	|-RVA: 0xE928C0 Offset: 0xE912C0 VA: 0x180E928C0
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0xE92470 Offset: 0xE90E70 VA: 0x180E92470
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE92CA0 Offset: 0xE916A0 VA: 0x180E92CA0
	|-Enumerable.SequenceEqual<MultiColumnCollectionHeader.SortedColumnState>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94FD0 Offset: 0xE939D0 VA: 0x180E94FD0
	|-Enumerable.ToArray<Color>
	|
	|-RVA: 0xE95060 Offset: 0xE93A60 VA: 0x180E95060
	|-Enumerable.ToArray<CombineInstance>
	|
	|-RVA: 0xE95210 Offset: 0xE93C10 VA: 0x180E95210
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0xE952A0 Offset: 0xE93CA0 VA: 0x180E952A0
	|-Enumerable.ToArray<InternedString>
	|
	|-RVA: 0xE95330 Offset: 0xE93D30 VA: 0x180E95330
	|-Enumerable.ToArray<NameAndParameters>
	|
	|-RVA: 0xE95450 Offset: 0xE93E50 VA: 0x180E95450
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0xE953C0 Offset: 0xE93DC0 VA: 0x180E953C0
	|-Enumerable.ToArray<RaycastHit>
	|
	|-RVA: 0xE954E0 Offset: 0xE93EE0 VA: 0x180E954E0
	|-Enumerable.ToArray<Scene>
	|
	|-RVA: 0xE95570 Offset: 0xE93F70 VA: 0x180E95570
	|-Enumerable.ToArray<float>
	|
	|-RVA: 0xE95600 Offset: 0xE94000 VA: 0x180E95600
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0xE95690 Offset: 0xE94090 VA: 0x180E95690
	|-Enumerable.ToArray<Vector2>
	|
	|-RVA: 0xE95720 Offset: 0xE94120 VA: 0x180E95720
	|-Enumerable.ToArray<Vector3>
	|
	|-RVA: 0xE95180 Offset: 0xE93B80 VA: 0x180E95180
	|-Enumerable.ToArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE950F0 Offset: 0xE93AF0 VA: 0x180E950F0
	|-Enumerable.ToArray<InputControlScheme.DeviceRequirement>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97350 Offset: 0xE95D50 VA: 0x180E97350
	|-Enumerable.ToList<KeyValuePair<object, object>>
	|
	|-RVA: 0xE978F0 Offset: 0xE962F0 VA: 0x180E978F0
	|-Enumerable.ToList<ValueTuple<object, object>>
	|
	|-RVA: 0xE96F90 Offset: 0xE95990 VA: 0x180E96F90
	|-Enumerable.ToList<CGSpot>
	|
	|-RVA: 0xE97030 Offset: 0xE95A30 VA: 0x180E97030
	|-Enumerable.ToList<Connection>
	|
	|-RVA: 0xE970D0 Offset: 0xE95AD0 VA: 0x180E970D0
	|-Enumerable.ToList<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xE972B0 Offset: 0xE95CB0 VA: 0x180E972B0
	|-Enumerable.ToList<int>
	|
	|-RVA: 0xE97210 Offset: 0xE95C10 VA: 0x180E97210
	|-Enumerable.ToList<Int32Enum>
	|
	|-RVA: 0xE973F0 Offset: 0xE95DF0 VA: 0x180E973F0
	|-Enumerable.ToList<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xE97490 Offset: 0xE95E90 VA: 0x180E97490
	|-Enumerable.ToList<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xE97530 Offset: 0xE95F30 VA: 0x180E97530
	|-Enumerable.ToList<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xE975D0 Offset: 0xE95FD0 VA: 0x180E975D0
	|-Enumerable.ToList<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xE97670 Offset: 0xE96070 VA: 0x180E97670
	|-Enumerable.ToList<NameAndParameters>
	|
	|-RVA: 0xE977B0 Offset: 0xE961B0 VA: 0x180E977B0
	|-Enumerable.ToList<object>
	|
	|-RVA: 0xE97710 Offset: 0xE96110 VA: 0x180E97710
	|-Enumerable.ToList<RaycastHit>
	|
	|-RVA: 0xE97850 Offset: 0xE96250 VA: 0x180E97850
	|-Enumerable.ToList<Scene>
	|
	|-RVA: 0xE97990 Offset: 0xE96390 VA: 0x180E97990
	|-Enumerable.ToList<Vector3>
	|
	|-RVA: 0xE97170 Offset: 0xE95B70 VA: 0x180E97170
	|-Enumerable.ToList<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE95FB0 Offset: 0xE949B0 VA: 0x180E95FB0
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0xE96360 Offset: 0xE94D60 VA: 0x180E96360
	|-Enumerable.ToDictionary<NamedValue, object, object>
	|
	|-RVA: 0xE96650 Offset: 0xE95050 VA: 0x180E96650
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0xE96940 Offset: 0xE95340 VA: 0x180E96940
	|-Enumerable.ToDictionary<object, object, bool>
	|
	|-RVA: 0xE969B0 Offset: 0xE953B0 VA: 0x180E969B0
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0xE96F20 Offset: 0xE95920 VA: 0x180E96F20
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0xE95C30 Offset: 0xE94630 VA: 0x180E95C30
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE95CA0 Offset: 0xE946A0 VA: 0x180E95CA0
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0xE96020 Offset: 0xE94A20 VA: 0x180E96020
	|-Enumerable.ToDictionary<NamedValue, object, object>
	|
	|-RVA: 0xE963D0 Offset: 0xE94DD0 VA: 0x180E963D0
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0xE966C0 Offset: 0xE950C0 VA: 0x180E966C0
	|-Enumerable.ToDictionary<object, object, bool>
	|
	|-RVA: 0xE96A20 Offset: 0xE95420 VA: 0x180E96A20
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0xE96CA0 Offset: 0xE956A0 VA: 0x180E96CA0
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0xE957B0 Offset: 0xE941B0 VA: 0x180E957B0
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90480 Offset: 0xE8EE80 VA: 0x180E90480
	|-Enumerable.OfType<object>
	|
	|-RVA: 0xE90410 Offset: 0xE8EE10 VA: 0x180E90410
	|-Enumerable.OfType<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<OfTypeIterator>d__97<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE864D0 Offset: 0xE84ED0 VA: 0x180E864D0
	|-Enumerable.OfTypeIterator<object>
	|
	|-RVA: 0xE86380 Offset: 0xE84D80 VA: 0x180E86380
	|-Enumerable.OfTypeIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE86560 Offset: 0xE84F60 VA: 0x180E86560
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0xE866E0 Offset: 0xE850E0 VA: 0x180E866E0
	|-Enumerable.Cast<Int32Enum>
	|
	|-RVA: 0xE867D0 Offset: 0xE851D0 VA: 0x180E867D0
	|-Enumerable.Cast<object>
	|
	|-RVA: 0xE86650 Offset: 0xE85050 VA: 0x180E86650
	|-Enumerable.Cast<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<CastIterator>d__99<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE862F0 Offset: 0xE84CF0 VA: 0x180E862F0
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0xE86440 Offset: 0xE84E40 VA: 0x180E86440
	|-Enumerable.CastIterator<Int32Enum>
	|
	|-RVA: 0xE864D0 Offset: 0xE84ED0 VA: 0x180E864D0
	|-Enumerable.CastIterator<object>
	|
	|-RVA: 0xE86380 Offset: 0xE84D80 VA: 0x180E86380
	|-Enumerable.CastIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8D420 Offset: 0xE8BE20 VA: 0x180E8D420
	|-Enumerable.First<BezierPathSegment>
	|
	|-RVA: 0xE8D680 Offset: 0xE8C080 VA: 0x180E8D680
	|-Enumerable.First<FrameTiming>
	|
	|-RVA: 0xE8DFC0 Offset: 0xE8C9C0 VA: 0x180E8DFC0
	|-Enumerable.First<int>
	|
	|-RVA: 0xE8E390 Offset: 0xE8CD90 VA: 0x180E8E390
	|-Enumerable.First<object>
	|
	|-RVA: 0xE8DD20 Offset: 0xE8C720 VA: 0x180E8DD20
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8E1D0 Offset: 0xE8CBD0 VA: 0x180E8E1D0
	|-Enumerable.First<object>
	|
	|-RVA: 0xE8DA10 Offset: 0xE8C410 VA: 0x180E8DA10
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8C640 Offset: 0xE8B040 VA: 0x180E8C640
	|-Enumerable.FirstOrDefault<CoordinateFootprintTilePair>
	|-Enumerable.FirstOrDefault<CoordinateStorageFootprintTilePair>
	|
	|-RVA: 0xE8D010 Offset: 0xE8BA10 VA: 0x180E8D010
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0xE8CCD0 Offset: 0xE8B6D0 VA: 0x180E8CCD0
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8D240 Offset: 0xE8BC40 VA: 0x180E8D240
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0xE8C930 Offset: 0xE8B330 VA: 0x180E8C930
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8F4E0 Offset: 0xE8DEE0 VA: 0x180E8F4E0
	|-Enumerable.Last<BezierPathSegment>
	|
	|-RVA: 0xE8FC70 Offset: 0xE8E670 VA: 0x180E8FC70
	|-Enumerable.Last<Int32Enum>
	|
	|-RVA: 0xE8FF80 Offset: 0xE8E980 VA: 0x180E8FF80
	|-Enumerable.Last<object>
	|
	|-RVA: 0xE8F860 Offset: 0xE8E260 VA: 0x180E8F860
	|-Enumerable.Last<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8EF70 Offset: 0xE8D970 VA: 0x180E8EF70
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0xE8E700 Offset: 0xE8D100 VA: 0x180E8E700
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8F2A0 Offset: 0xE8DCA0 VA: 0x180E8F2A0
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0xE8EBC0 Offset: 0xE8D5C0 VA: 0x180E8EBC0
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94AE0 Offset: 0xE934E0 VA: 0x180E94AE0
	|-Enumerable.Single<object>
	|
	|-RVA: 0xE94220 Offset: 0xE92C20 VA: 0x180E94220
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94560 Offset: 0xE92F60 VA: 0x180E94560
	|-Enumerable.Single<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0xE94860 Offset: 0xE93260 VA: 0x180E94860
	|-Enumerable.Single<object>
	|
	|-RVA: 0xE93E50 Offset: 0xE92850 VA: 0x180E93E50
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE93BF0 Offset: 0xE925F0 VA: 0x180E93BF0
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0xE93200 Offset: 0xE91C00 VA: 0x180E93200
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE93970 Offset: 0xE92370 VA: 0x180E93970
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0xE93560 Offset: 0xE91F60 VA: 0x180E93560
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8B8A0 Offset: 0xE8A2A0 VA: 0x180E8B8A0
	|-Enumerable.ElementAt<KeyValuePair<object, float>>
	|
	|-RVA: 0xE8AE80 Offset: 0xE89880 VA: 0x180E8AE80
	|-Enumerable.ElementAt<CGSpot>
	|
	|-RVA: 0xE8B600 Offset: 0xE8A000 VA: 0x180E8B600
	|-Enumerable.ElementAt<int>
	|
	|-RVA: 0xE8BC30 Offset: 0xE8A630 VA: 0x180E8BC30
	|-Enumerable.ElementAt<Label>
	|
	|-RVA: 0xE8C050 Offset: 0xE8AA50 VA: 0x180E8C050
	|-Enumerable.ElementAt<object>
	|
	|-RVA: 0xE8C2F0 Offset: 0xE8ACF0 VA: 0x180E8C2F0
	|-Enumerable.ElementAt<uint>
	|
	|-RVA: 0xE8B2B0 Offset: 0xE89CB0 VA: 0x180E8B2B0
	|-Enumerable.ElementAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F84980 Offset: 0x1F83380 VA: 0x181F84980
	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachine(typeof(Enumerable.<RangeIterator>d__115))]
	// RVA: 0x1F84900 Offset: 0x1F83300 VA: 0x181F84900
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Empty<TResult>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454A40 Offset: 0x453440 VA: 0x180454A40
	|-Enumerable.Empty<int>
	|-Enumerable.Empty<NameAndParameters>
	|-Enumerable.Empty<object>
	|-Enumerable.Empty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE85D90 Offset: 0xE84790 VA: 0x180E85D90
	|-Enumerable.Any<int>
	|-Enumerable.Any<object>
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE858F0 Offset: 0xE842F0 VA: 0x180E858F0
	|-Enumerable.Any<bool>
	|
	|-RVA: 0xE85ED0 Offset: 0xE848D0 VA: 0x180E85ED0
	|-Enumerable.Any<object>
	|
	|-RVA: 0xE860B0 Offset: 0xE84AB0 VA: 0x180E860B0
	|-Enumerable.Any<ulong>
	|
	|-RVA: 0xE85AD0 Offset: 0xE844D0 VA: 0x180E85AD0
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE85210 Offset: 0xE83C10 VA: 0x180E85210
	|-Enumerable.All<char>
	|
	|-RVA: 0xE85710 Offset: 0xE84110 VA: 0x180E85710
	|-Enumerable.All<object>
	|
	|-RVA: 0xE85450 Offset: 0xE83E50 VA: 0x180E85450
	|-Enumerable.All<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8A0B0 Offset: 0xE88AB0 VA: 0x180E8A0B0
	|-Enumerable.Count<KeyValuePair<int, int>>
	|-Enumerable.Count<KeyValuePair<object, bool>>
	|-Enumerable.Count<BezierSegment>
	|-Enumerable.Count<CGSpot>
	|-Enumerable.Count<GCHandle>
	|-Enumerable.Count<int>
	|-Enumerable.Count<InternedString>
	|-Enumerable.Count<object>
	|-Enumerable.Count<PointerModel>
	|-Enumerable.Count<Substring>
	|-Enumerable.Count<uint>
	|-Enumerable.Count<ulong>
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	|-Enumerable.Count<InputManager.StateChangeMonitorTimeout>
	|-Enumerable.Count<InputUser.OngoingAccountSelection>
	|-Enumerable.Count<OnScreenControl.OnScreenDeviceInfo>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8A2B0 Offset: 0xE88CB0 VA: 0x180E8A2B0
	|-Enumerable.Count<CSteamID>
	|
	|-RVA: 0xE8A7F0 Offset: 0xE891F0 VA: 0x180E8A7F0
	|-Enumerable.Count<object>
	|
	|-RVA: 0xE8A500 Offset: 0xE88F00 VA: 0x180E8A500
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE89CE0 Offset: 0xE886E0 VA: 0x180E89CE0
	|-Enumerable.Contains<int>
	|
	|-RVA: 0xE89650 Offset: 0xE88050 VA: 0x180E89650
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0xE89D90 Offset: 0xE88790 VA: 0x180E89D90
	|-Enumerable.Contains<object>
	|
	|-RVA: 0xE89160 Offset: 0xE87B60 VA: 0x180E89160
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE89040 Offset: 0xE87A40 VA: 0x180E89040
	|-Enumerable.Contains<HIDSupport.HIDPageUsage>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE899F0 Offset: 0xE883F0 VA: 0x180E899F0
	|-Enumerable.Contains<int>
	|
	|-RVA: 0xE89700 Offset: 0xE88100 VA: 0x180E89700
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0xE89EB0 Offset: 0xE888B0 VA: 0x180E89EB0
	|-Enumerable.Contains<object>
	|
	|-RVA: 0xE89330 Offset: 0xE87D30 VA: 0x180E89330
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE88C80 Offset: 0xE87680 VA: 0x180E88C80
	|-Enumerable.Contains<HIDSupport.HIDPageUsage>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TAccumulate Aggregate<TSource, TAccumulate>(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84FA0 Offset: 0xE839A0 VA: 0x180E84FA0
	|-Enumerable.Aggregate<object, Color>
	|
	|-RVA: 0xE84B30 Offset: 0xE83530 VA: 0x180E84B30
	|-Enumerable.Aggregate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1F84A40 Offset: 0x1F83440 VA: 0x181F84A40
	public static int Sum(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x1F84BF0 Offset: 0x1F835F0 VA: 0x181F84BF0
	public static float Sum(IEnumerable<float> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94E70 Offset: 0xE93870 VA: 0x180E94E70
	|-Enumerable.Sum<object>
	|
	|-RVA: 0xE94D50 Offset: 0xE93750 VA: 0x180E94D50
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94E10 Offset: 0xE93810 VA: 0x180E94E10
	|-Enumerable.Sum<object>
	|
	|-RVA: 0xE94DB0 Offset: 0xE937B0 VA: 0x180E94DB0
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1F84450 Offset: 0x1F82E50 VA: 0x181F84450
	public static int Min(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x1F846A0 Offset: 0x1F830A0 VA: 0x181F846A0
	public static float Min(IEnumerable<float> source) { }

	[Extension]
	// RVA: 0x1F84200 Offset: 0x1F82C00 VA: 0x181F84200
	public static int Max(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x1F83F60 Offset: 0x1F82960 VA: 0x181F83F60
	public static float Max(IEnumerable<float> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int Max<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90350 Offset: 0xE8ED50 VA: 0x180E90350
	|-Enumerable.Max<object>
	|
	|-RVA: 0xE902F0 Offset: 0xE8ECF0 VA: 0x180E902F0
	|-Enumerable.Max<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float Max<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE903B0 Offset: 0xE8EDB0 VA: 0x180E903B0
	|-Enumerable.Max<object>
	|
	|-RVA: 0xE90290 Offset: 0xE8EC90 VA: 0x180E90290
	|-Enumerable.Max<__Il2CppFullySharedGenericType>
	*/
}
