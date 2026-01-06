using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class AlisonKnight : NPC
{
	public new static string NPCId => "alison_knight";

	internal AlisonKnight()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "alison_knight"))
	{
	}
}
