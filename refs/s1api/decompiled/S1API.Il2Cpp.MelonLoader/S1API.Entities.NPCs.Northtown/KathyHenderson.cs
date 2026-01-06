using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class KathyHenderson : NPC
{
	public new static string NPCId => "kathy_henderson";

	internal KathyHenderson()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "kathy_henderson"))
	{
	}
}
