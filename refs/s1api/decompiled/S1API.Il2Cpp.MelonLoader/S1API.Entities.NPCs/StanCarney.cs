using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class StanCarney : NPC
{
	public new static string NPCId => "stan_carney";

	internal StanCarney()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "stan_carney"))
	{
	}
}
