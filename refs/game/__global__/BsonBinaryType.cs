internal enum BsonBinaryType // TypeDefIndex: 11430
{
	// Fields
	public byte value__; // 0x0
	public const BsonBinaryType Binary = 0;
	public const BsonBinaryType Function = 1;
	[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
	public const BsonBinaryType BinaryOld = 2;
	[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
	public const BsonBinaryType UuidOld = 3;
	public const BsonBinaryType Uuid = 4;
	public const BsonBinaryType Md5 = 5;
	public const BsonBinaryType UserDefined = 128;
}
