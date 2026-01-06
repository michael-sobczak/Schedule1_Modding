using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class LilyTurner : NPC
{
	public new static string NPCId => "lily_turner";

	internal LilyTurner()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "lily_turner"))
	{
	}
}
