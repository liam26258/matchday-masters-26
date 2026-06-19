using UnityEngine;

public class CareerManager : MonoBehaviour
{
    private CareerData playerCareer;
    private CareerData managerCareer;
    private int currentSeason;

    public void StartPlayerCareer(PlayerData player, TeamData team)
    {
        playerCareer = new CareerData
        {
            player = player,
            team = team,
            season = 1,
            level = 1,
            xp = 0
        };
        currentSeason = 1;
    }

    public void StartManagerCareer(TeamData team)
    {
        managerCareer = new CareerData
        {
            team = team,
            season = 1
        };
        currentSeason = 1;
    }

    public void UpdateCareerProgress(int xpGained)
    {
        if (playerCareer != null)
        {
            playerCareer.xp += xpGained;
            if (playerCareer.xp >= 1000)
            {
                playerCareer.level++;
                playerCareer.xp -= 1000;
            }
        }
    }

    public void AdvanceSeason()
    {
        currentSeason++;
        // Handle seasonal updates
    }

    public CareerData GetPlayerCareer() => playerCareer;
    public CareerData GetManagerCareer() => managerCareer;
}