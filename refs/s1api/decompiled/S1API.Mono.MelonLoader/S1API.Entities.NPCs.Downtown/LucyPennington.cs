using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class LucyPennington : NPC
{
	public new static string NPCId => "lucy_pennington";

	internal LucyPennington()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "lucy_pennington"))
	{
	}
}
