using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class AustinSteiner : NPC
{
	public new static string NPCId => "austin_steiner";

	internal AustinSteiner()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "austin_steiner"))
	{
	}
}
