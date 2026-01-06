using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class CarlBundy : NPC
{
	public new static string NPCId => "carl_bundy";

	internal CarlBundy()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "carl_bundy"))
	{
	}
}
