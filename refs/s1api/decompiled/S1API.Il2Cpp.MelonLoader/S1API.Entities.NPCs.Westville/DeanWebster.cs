using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class DeanWebster : NPC
{
	public new static string NPCId => "dean_webster";

	internal DeanWebster()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "dean_webster"))
	{
	}
}
