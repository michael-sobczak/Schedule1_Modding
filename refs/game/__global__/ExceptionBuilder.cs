internal static class ExceptionBuilder // TypeDefIndex: 12862
{
	// Methods

	// RVA: 0x205E310 Offset: 0x205CD10 VA: 0x18205E310
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x205E0D0 Offset: 0x205CAD0 VA: 0x18205E0D0
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x205E190 Offset: 0x205CB90 VA: 0x18205E190
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x205E250 Offset: 0x205CC50 VA: 0x18205E250
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x205EB00 Offset: 0x205D500 VA: 0x18205EB00
	internal static Exception _Argument(string error) { }

	// RVA: 0x205EA90 Offset: 0x205D490 VA: 0x18205EA90
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x205E9B0 Offset: 0x205D3B0 VA: 0x18205E9B0
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x205EA20 Offset: 0x205D420 VA: 0x18205EA20
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x205ED20 Offset: 0x205D720 VA: 0x18205ED20
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x205EE50 Offset: 0x205D850 VA: 0x18205EE50
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x205EDF0 Offset: 0x205D7F0 VA: 0x18205EDF0
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9A080 Offset: 0xE98A80 VA: 0x180E9A080
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0xE99F20 Offset: 0xE98920 VA: 0x180E99F20
	|-ExceptionBuilder._InvalidEnumArgumentException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x205DF80 Offset: 0x205C980 VA: 0x18205DF80
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x205A760 Offset: 0x2059160 VA: 0x18205A760
	private static Exception _Data(string error) { }

	// RVA: 0x205EB60 Offset: 0x205D560 VA: 0x18205EB60
	private static Exception _Constraint(string error) { }

	// RVA: 0x205ED80 Offset: 0x205D780 VA: 0x18205ED80
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x205EBD0 Offset: 0x205D5D0 VA: 0x18205EBD0
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x205EC40 Offset: 0x205D640 VA: 0x18205EC40
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x205ECB0 Offset: 0x205D6B0 VA: 0x18205ECB0
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x205EEB0 Offset: 0x205D8B0 VA: 0x18205EEB0
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x205EF20 Offset: 0x205D920 VA: 0x18205EF20
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x205EF90 Offset: 0x205D990 VA: 0x18205EF90
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x205F000 Offset: 0x205DA00 VA: 0x18205F000
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x2054990 Offset: 0x2053390 VA: 0x182054990
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x2054A70 Offset: 0x2053470 VA: 0x182054A70
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x2054E50 Offset: 0x2053850 VA: 0x182054E50
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x205E3A0 Offset: 0x205CDA0 VA: 0x18205E3A0
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0x2055D30 Offset: 0x2054730 VA: 0x182055D30
	public static Exception CannotModifyCollection() { }

	// RVA: 0x2056760 Offset: 0x2055160 VA: 0x182056760
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x205AD40 Offset: 0x2059740 VA: 0x18205AD40
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x2059880 Offset: 0x2058280 VA: 0x182059880
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x2056B00 Offset: 0x2055500 VA: 0x182056B00
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x2056A80 Offset: 0x2055480 VA: 0x182056A80
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x2056BA0 Offset: 0x20555A0 VA: 0x182056BA0
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x2056CB0 Offset: 0x20556B0 VA: 0x182056CB0
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x20554F0 Offset: 0x2053EF0 VA: 0x1820554F0
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x20555C0 Offset: 0x2053FC0 VA: 0x1820555C0
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x2055690 Offset: 0x2054090 VA: 0x182055690
	public static Exception CannotAddColumn3() { }

	// RVA: 0x2055710 Offset: 0x2054110 VA: 0x182055710
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x2055980 Offset: 0x2054380 VA: 0x182055980
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x20557E0 Offset: 0x20541E0 VA: 0x1820557E0
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x20558B0 Offset: 0x20542B0 VA: 0x1820558B0
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x2055E80 Offset: 0x2054880 VA: 0x182055E80
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x2056040 Offset: 0x2054A40 VA: 0x182056040
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x2055DB0 Offset: 0x20547B0 VA: 0x182055DB0
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x2055F00 Offset: 0x2054900 VA: 0x182055F00
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x2055FA0 Offset: 0x20549A0 VA: 0x182055FA0
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x2054810 Offset: 0x2053210 VA: 0x182054810
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x205B040 Offset: 0x2059A40 VA: 0x18205B040
	public static Exception NoConstraintName() { }

	// RVA: 0x2057330 Offset: 0x2055D30 VA: 0x182057330
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x205A400 Offset: 0x2058E00 VA: 0x18205A400
	public static string KeysToString(object[] keys) { }

	// RVA: 0x205E6C0 Offset: 0x205D0C0 VA: 0x18205E6C0
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x20572C0 Offset: 0x2055CC0 VA: 0x1820572C0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x20570B0 Offset: 0x2055AB0 VA: 0x1820570B0
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x2057ED0 Offset: 0x20568D0 VA: 0x182057ED0
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x2057D30 Offset: 0x2056730 VA: 0x182057D30
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x205AE10 Offset: 0x2059810 VA: 0x18205AE10
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x205E8B0 Offset: 0x205D2B0 VA: 0x18205E8B0
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x2057030 Offset: 0x2055A30 VA: 0x182057030
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x20571C0 Offset: 0x2055BC0 VA: 0x1820571C0
	public static Exception ConstraintParentValues() { }

	// RVA: 0x2056F40 Offset: 0x2055940 VA: 0x182056F40
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x2057240 Offset: 0x2055C40 VA: 0x182057240
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x20588D0 Offset: 0x20572D0 VA: 0x1820588D0
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x20589A0 Offset: 0x20573A0 VA: 0x1820589A0
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x2058A70 Offset: 0x2057470 VA: 0x182058A70
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x2058B20 Offset: 0x2057520 VA: 0x182058B20
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x205C8C0 Offset: 0x205B2C0 VA: 0x18205C8C0
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x205A6D0 Offset: 0x20590D0 VA: 0x18205A6D0
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x205B3C0 Offset: 0x2059DC0 VA: 0x18205B3C0
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x2056520 Offset: 0x2054F20 VA: 0x182056520
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x2054C80 Offset: 0x2053680 VA: 0x182054C80
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x2054C00 Offset: 0x2053600 VA: 0x182054C00
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x2054DD0 Offset: 0x20537D0 VA: 0x182054DD0
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x20565F0 Offset: 0x2054FF0 VA: 0x1820565F0
	public static Exception CantChangeDataType() { }

	// RVA: 0x205B4E0 Offset: 0x2059EE0 VA: 0x18205B4E0
	public static Exception NullDataType() { }

	// RVA: 0x2056A00 Offset: 0x2055400 VA: 0x182056A00
	public static Exception ColumnNameRequired() { }

	// RVA: 0x2057810 Offset: 0x2056210 VA: 0x182057810
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x2057990 Offset: 0x2056390 VA: 0x182057990
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x2057890 Offset: 0x2056290 VA: 0x182057890
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x20586F0 Offset: 0x20570F0 VA: 0x1820586F0
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x2058670 Offset: 0x2057070 VA: 0x182058670
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x20585B0 Offset: 0x2056FB0 VA: 0x1820585B0
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x20587F0 Offset: 0x20571F0 VA: 0x1820587F0
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x2058770 Offset: 0x2057170 VA: 0x182058770
	public static Exception ExpressionCircular() { }

	// RVA: 0x205B2F0 Offset: 0x2059CF0 VA: 0x18205B2F0
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x205B560 Offset: 0x2059F60 VA: 0x18205B560
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x205B6C0 Offset: 0x205A0C0 VA: 0x18205B6C0
	public static Exception NullValues(string column) { }

	// RVA: 0x205BBA0 Offset: 0x205A5A0 VA: 0x18205BBA0
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x205BC30 Offset: 0x205A630 VA: 0x18205BC30
	public static Exception ReadOnly(string column) { }

	// RVA: 0x205E640 Offset: 0x205D040 VA: 0x18205E640
	public static Exception UniqueAndExpression() { }

	// RVA: 0x205D3E0 Offset: 0x205BDE0 VA: 0x18205D3E0
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x2056440 Offset: 0x2054E40 VA: 0x182056440
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x205A520 Offset: 0x2058F20 VA: 0x18205A520
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x2056220 Offset: 0x2054C20 VA: 0x182056220
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x2056140 Offset: 0x2054B40 VA: 0x182056140
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x2056300 Offset: 0x2054D00 VA: 0x182056300
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x20563A0 Offset: 0x2054DA0 VA: 0x1820563A0
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x2055AF0 Offset: 0x20544F0 VA: 0x182055AF0
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x2058E90 Offset: 0x2057890 VA: 0x182058E90
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x2054D00 Offset: 0x2053700 VA: 0x182054D00
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x2059040 Offset: 0x2057A40 VA: 0x182059040
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x2058F70 Offset: 0x2057970 VA: 0x182058F70
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x205E4A0 Offset: 0x205CEA0 VA: 0x18205E4A0
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x2059500 Offset: 0x2057F00 VA: 0x182059500
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x20560C0 Offset: 0x2054AC0 VA: 0x1820560C0
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x2059600 Offset: 0x2058000 VA: 0x182059600
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x2056670 Offset: 0x2055070 VA: 0x182056670
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x2056E50 Offset: 0x2055850 VA: 0x182056E50
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x205D530 Offset: 0x205BF30 VA: 0x18205D530
	public static Exception SetFailed(string name) { }

	// RVA: 0x2055340 Offset: 0x2053D40 VA: 0x182055340
	public static Exception CanNotUseDataViewManager() { }

	// RVA: 0x20553D0 Offset: 0x2053DD0 VA: 0x1820553D0
	public static Exception CanNotUse() { }

	// RVA: 0x205D600 Offset: 0x205C000 VA: 0x18205D600
	public static Exception SetIListObject() { }

	// RVA: 0x2054780 Offset: 0x2053180 VA: 0x182054780
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x205B450 Offset: 0x2059E50 VA: 0x18205B450
	public static Exception NotOpen() { }

	// RVA: 0x20574E0 Offset: 0x2055EE0 VA: 0x1820574E0
	public static Exception CreateChildView() { }

	// RVA: 0x2055030 Offset: 0x2053A30 VA: 0x182055030
	public static Exception CanNotDelete() { }

	// RVA: 0x2058CE0 Offset: 0x20576E0 VA: 0x182058CE0
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x2054700 Offset: 0x2053100 VA: 0x182054700
	public static Exception AddExternalObject() { }

	// RVA: 0x2054FB0 Offset: 0x20539B0 VA: 0x182054FB0
	public static Exception CanNotClear() { }

	// RVA: 0x20592F0 Offset: 0x2057CF0 VA: 0x1820592F0
	public static Exception InsertExternalObject() { }

	// RVA: 0x205C840 Offset: 0x205B240 VA: 0x18205C840
	public static Exception RemoveExternalObject() { }

	// RVA: 0x205A260 Offset: 0x2058C60 VA: 0x18205A260
	public static Exception KeyTableMismatch() { }

	// RVA: 0x205A1D0 Offset: 0x2058BD0 VA: 0x18205A1D0
	public static Exception KeyNoColumns() { }

	// RVA: 0x205A2F0 Offset: 0x2058CF0 VA: 0x18205A2F0
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x205A000 Offset: 0x2058A00 VA: 0x18205A000
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x205C0A0 Offset: 0x205AAA0 VA: 0x18205C0A0
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x2056EB0 Offset: 0x20558B0 VA: 0x182056EB0
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x205A0D0 Offset: 0x2058AD0 VA: 0x18205A0D0
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x205A150 Offset: 0x2058B50 VA: 0x18205A150
	public static Exception KeyLengthZero() { }

	// RVA: 0x2058BD0 Offset: 0x20575D0 VA: 0x182058BD0
	public static Exception ForeignRelation() { }

	// RVA: 0x2059F70 Offset: 0x2058970 VA: 0x182059F70
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x205C2B0 Offset: 0x205ACB0 VA: 0x18205C2B0
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x2058DF0 Offset: 0x20577F0 VA: 0x182058DF0
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x205D680 Offset: 0x205C080 VA: 0x18205D680
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x205C230 Offset: 0x205AC30 VA: 0x18205C230
	public static Exception RelationForeignRow() { }

	// RVA: 0x205C350 Offset: 0x205AD50 VA: 0x18205C350
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x205D9B0 Offset: 0x205C3B0 VA: 0x18205D9B0
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x205A600 Offset: 0x2059000 VA: 0x18205A600
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x205C1B0 Offset: 0x205ABB0 VA: 0x18205C1B0
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x205B790 Offset: 0x205A190 VA: 0x18205B790
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x2059110 Offset: 0x2057B10 VA: 0x182059110
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x2059900 Offset: 0x2058300 VA: 0x182059900
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x205CF10 Offset: 0x205B910 VA: 0x18205CF10
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x205CF90 Offset: 0x205B990 VA: 0x18205CF90
	public static Exception RowNotInTheTable() { }

	// RVA: 0x20582B0 Offset: 0x2056CB0 VA: 0x1820582B0
	public static Exception EditInRowChanging() { }

	// RVA: 0x2058410 Offset: 0x2056E10 VA: 0x182058410
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x2054F20 Offset: 0x2053920 VA: 0x182054F20
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x2055460 Offset: 0x2053E60 VA: 0x182055460
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x2057AB0 Offset: 0x20564B0 VA: 0x182057AB0
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x205E930 Offset: 0x205D330 VA: 0x18205E930
	public static Exception ValueArrayLength() { }

	// RVA: 0x205B0C0 Offset: 0x2059AC0 VA: 0x18205B0C0
	public static Exception NoCurrentData() { }

	// RVA: 0x205B150 Offset: 0x2059B50 VA: 0x18205B150
	public static Exception NoOriginalData() { }

	// RVA: 0x205B1E0 Offset: 0x2059BE0 VA: 0x18205B1E0
	public static Exception NoProposedData() { }

	// RVA: 0x205D130 Offset: 0x205BB30 VA: 0x18205D130
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x2057B40 Offset: 0x2056540 VA: 0x182057B40
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x205CAD0 Offset: 0x205B4D0 VA: 0x18205CAD0
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x205CCF0 Offset: 0x205B6F0 VA: 0x18205CCF0
	public static Exception RowEmpty() { }

	// RVA: 0x2059BA0 Offset: 0x20585A0 VA: 0x182059BA0
	public static Exception InvalidRowVersion() { }

	// RVA: 0x205D020 Offset: 0x205BA20 VA: 0x18205D020
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x205CE40 Offset: 0x205B840 VA: 0x18205CE40
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x205CD70 Offset: 0x205B770 VA: 0x18205CD70
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x205CC60 Offset: 0x205B660 VA: 0x18205CC60
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x205AC30 Offset: 0x2059630 VA: 0x18205AC30
	public static Exception MultipleParents() { }

	// RVA: 0x2059B60 Offset: 0x2058560 VA: 0x182059B60
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x2059AE0 Offset: 0x20584E0 VA: 0x182059AE0
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x205D360 Offset: 0x205BD60 VA: 0x18205D360
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x205D290 Offset: 0x205BC90 VA: 0x18205D290
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x2057560 Offset: 0x2055F60 VA: 0x182057560
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x205A7D0 Offset: 0x20591D0 VA: 0x18205A7D0
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x205DF00 Offset: 0x205C900 VA: 0x18205DF00
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x205BD80 Offset: 0x205A780 VA: 0x18205BD80
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x205CB60 Offset: 0x205B560 VA: 0x18205CB60
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x205CBE0 Offset: 0x205B5E0 VA: 0x18205CBE0
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x205BD00 Offset: 0x205A700 VA: 0x18205BD00
	public static Exception RecordStateRange() { }

	// RVA: 0x20591E0 Offset: 0x2057BE0 VA: 0x1820591E0
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x205C9C0 Offset: 0x205B3C0 VA: 0x18205C9C0
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x205BE00 Offset: 0x205A800 VA: 0x18205BE00
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x205BE80 Offset: 0x205A880 VA: 0x18205BE80
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x205C3D0 Offset: 0x205ADD0 VA: 0x18205C3D0
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x205C4A0 Offset: 0x205AEA0 VA: 0x18205C4A0
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x2058070 Offset: 0x2056A70 VA: 0x182058070
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x205C740 Offset: 0x205B140 VA: 0x18205C740
	public static Exception RelationTableNull() { }

	// RVA: 0x205C130 Offset: 0x205AB30 VA: 0x18205C130
	public static Exception RelationDataSetNull() { }

	// RVA: 0x205C7C0 Offset: 0x205B1C0 VA: 0x18205C7C0
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x205B820 Offset: 0x205A220 VA: 0x18205B820
	public static Exception ParentTableMismatch() { }

	// RVA: 0x20568B0 Offset: 0x20552B0 VA: 0x1820568B0
	public static Exception ChildTableMismatch() { }

	// RVA: 0x20584A0 Offset: 0x2056EA0 VA: 0x1820584A0
	public static Exception EnforceConstraint() { }

	// RVA: 0x2056830 Offset: 0x2055230 VA: 0x182056830
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x2055A50 Offset: 0x2054450 VA: 0x182055A50
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x2055A60 Offset: 0x2054460 VA: 0x182055A60
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x2059AA0 Offset: 0x20584A0 VA: 0x182059AA0
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x205DA80 Offset: 0x205C480 VA: 0x18205DA80
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x205D930 Offset: 0x205C330 VA: 0x18205D930
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x205B270 Offset: 0x2059C70 VA: 0x18205B270
	public static Exception NoTableName() { }

	// RVA: 0x205ACC0 Offset: 0x20596C0 VA: 0x18205ACC0
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x2059D00 Offset: 0x2058700 VA: 0x182059D00
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x20581E0 Offset: 0x2056BE0 VA: 0x1820581E0
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x2058140 Offset: 0x2056B40 VA: 0x182058140
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x205D1C0 Offset: 0x205BBC0 VA: 0x18205D1C0
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x20576B0 Offset: 0x20560B0 VA: 0x1820576B0
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x205D830 Offset: 0x205C230 VA: 0x18205D830
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x205D8B0 Offset: 0x205C2B0 VA: 0x18205D8B0
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x205DDF0 Offset: 0x205C7F0 VA: 0x18205DDF0
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x205DD20 Offset: 0x205C720 VA: 0x18205DD20
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x205DBD0 Offset: 0x205C5D0 VA: 0x18205DBD0
	public static Exception TableInRelation() { }

	// RVA: 0x205DB00 Offset: 0x205C500 VA: 0x18205DB00
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x20551C0 Offset: 0x2053BC0 VA: 0x1820551C0
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x2055140 Offset: 0x2053B40 VA: 0x182055140
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x20552C0 Offset: 0x2053CC0 VA: 0x1820552C0
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x2055240 Offset: 0x2053C40 VA: 0x182055240
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x205DC50 Offset: 0x205C650 VA: 0x18205DC50
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x2054890 Offset: 0x2053290 VA: 0x182054890
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x2059DD0 Offset: 0x20587D0 VA: 0x182059DD0
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x205BAB0 Offset: 0x205A4B0 VA: 0x18205BAB0
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x205B630 Offset: 0x205A030 VA: 0x18205B630
	public static Exception NullRange() { }

	// RVA: 0x205AEF0 Offset: 0x20598F0 VA: 0x18205AEF0
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x205B970 Offset: 0x205A370 VA: 0x18205B970
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x205D7B0 Offset: 0x205C1B0 VA: 0x18205D7B0
	public static Exception StorageSetFailed() { }

	// RVA: 0x205D720 Offset: 0x205C120 VA: 0x18205D720
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x205A9D0 Offset: 0x20593D0 VA: 0x18205A9D0
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x205A930 Offset: 0x2059330 VA: 0x18205A930
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x2059460 Offset: 0x2057E60 VA: 0x182059460
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x2054B50 Offset: 0x2053550 VA: 0x182054B50
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x2058340 Offset: 0x2056D40 VA: 0x182058340
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x205C5A0 Offset: 0x205AFA0 VA: 0x18205C5A0
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x205BFD0 Offset: 0x205A9D0 VA: 0x18205BFD0
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x205C670 Offset: 0x205B070 VA: 0x18205C670
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x205BF00 Offset: 0x205A900 VA: 0x18205BF00
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x205E570 Offset: 0x205CF70 VA: 0x18205E570
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x2057780 Offset: 0x2056180 VA: 0x182057780
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x205A8A0 Offset: 0x20592A0 VA: 0x18205A8A0
	public static Exception MismatchKeyLength() { }

	// RVA: 0x20596E0 Offset: 0x20580E0 VA: 0x1820596E0
	public static Exception InvalidField(string name) { }

	// RVA: 0x2059C30 Offset: 0x2058630 VA: 0x182059C30
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x2056930 Offset: 0x2055330 VA: 0x182056930
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x2055C60 Offset: 0x2054660 VA: 0x182055C60
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x20597B0 Offset: 0x20581B0 VA: 0x1820597B0
	public static Exception InvalidKey(string name) { }

	// RVA: 0x2057C60 Offset: 0x2056660 VA: 0x182057C60
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x2057BD0 Offset: 0x20565D0 VA: 0x182057BD0
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x2057E00 Offset: 0x2056800 VA: 0x182057E00
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x2056D80 Offset: 0x2055780 VA: 0x182056D80
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x2055BC0 Offset: 0x20545C0 VA: 0x182055BC0
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x205AAA0 Offset: 0x20594A0 VA: 0x18205AAA0
	public static Exception MissingRefer(string name) { }

	// RVA: 0x20599D0 Offset: 0x20583D0 VA: 0x1820599D0
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x20550C0 Offset: 0x2053AC0 VA: 0x1820550C0
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x2059EE0 Offset: 0x20588E0 VA: 0x182059EE0
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x205E040 Offset: 0x205CA40 VA: 0x18205E040
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x205AF70 Offset: 0x2059970 VA: 0x18205AF70
	public static Exception NestedCircular(string name) { }

	// RVA: 0x205AB60 Offset: 0x2059560 VA: 0x18205AB60
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x205B8A0 Offset: 0x205A2A0 VA: 0x18205B8A0
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x2057630 Offset: 0x2056030 VA: 0x182057630
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x205DFF0 Offset: 0x205C9F0 VA: 0x18205DFF0
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x2057FA0 Offset: 0x20569A0 VA: 0x182057FA0
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x2058C50 Offset: 0x2057650 VA: 0x182058C50
	public static Exception FoundEntity() { }

	// RVA: 0x205A760 Offset: 0x2059160 VA: 0x18205A760
	public static Exception MergeFailed(string name) { }

	// RVA: 0x2057400 Offset: 0x2055E00 VA: 0x182057400
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x2059640 Offset: 0x2058040 VA: 0x182059640
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x2059370 Offset: 0x2057D70 VA: 0x182059370
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x2058530 Offset: 0x2056F30 VA: 0x182058530
	public static Exception EnumeratorModified() { }
}
