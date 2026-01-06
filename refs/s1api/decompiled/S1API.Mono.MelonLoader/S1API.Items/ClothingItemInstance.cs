using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;

namespace S1API.Items;

public class ClothingItemInstance : ItemInstance
{
	internal readonly ClothingInstance S1ClothingInstance;

	public ClothingColor Color
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (ClothingColor)S1ClothingInstance.Color;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			S1ClothingInstance.Color = (EClothingColor)value;
		}
	}

	public new ClothingItemDefinition Definition => new ClothingItemDefinition((ClothingDefinition)((ItemInstance)S1ClothingInstance).Definition);

	internal ClothingItemInstance(ClothingInstance itemInstance)
		: base((ItemInstance)(object)itemInstance)
	{
		S1ClothingInstance = itemInstance;
	}
}
