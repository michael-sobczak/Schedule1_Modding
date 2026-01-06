using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class JackKnight : NPC
{
	public new static string NPCId => "jack_knight";

	internal JackKnight()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jack_knight"))
	{
	}
}
