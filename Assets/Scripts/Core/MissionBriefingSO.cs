using UnityEngine;

[CreateAssetMenu(fileName = "NewMissionBriefing", menuName = "Subway Static/Mission Briefing")]
public class MissionBriefingSO : ScriptableObject
{
    [TextArea(2, 5)]
    public string introText;

    [TextArea(2, 5)]
    public string missionGoal;

    [TextArea(2, 5)]
    public string knownThreat;

    [TextArea(2, 5)]
    public string flavorText;

    public string speakerName;
}