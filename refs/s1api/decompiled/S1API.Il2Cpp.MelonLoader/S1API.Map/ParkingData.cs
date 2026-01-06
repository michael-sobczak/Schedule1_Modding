using Il2CppScheduleOne.Vehicles;
using S1API.Vehicles;

namespace S1API.Map;

public class ParkingData(string _lotId, int _index, ParkingAlignment _align)
{
	public string LotId => _lotId;

	public int Index => _index;

	public ParkingAlignment Alignment => _align;

	internal ParkingData(ParkData data)
		: this(((object)data.lotGUID/*cast due to .constrained prefix*/).ToString(), data.spotIndex, (ParkingAlignment)data.alignment)
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)
	//IL_0007: Unknown result type (might be due to invalid IL or missing references)
	//IL_001c: Unknown result type (might be due to invalid IL or missing references)
	//IL_0026: Expected I4, but got Unknown

}
