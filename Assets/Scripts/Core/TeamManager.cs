using UnityEngine;
using System.Collections.Generic;

public class TeamManager : MonoBehaviour
{
    [SerializeField] private List<TeamData> allTeams;
    private Dictionary<string, TeamData> teamDictionary;

    private void Start()
    {
        InitializeTeams();
    }

    private void InitializeTeams()
    {
        teamDictionary = new Dictionary<string, TeamData>();
        foreach (var team in allTeams)
        {
            teamDictionary[team.teamId] = team;
        }
    }

    public TeamData GetTeam(string teamId)
    {
        return teamDictionary.TryGetValue(teamId, out var team) ? team : null;
    }

    public List<TeamData> GetTeamsByLeague(string league)
    {
        var teamsInLeague = new List<TeamData>();
        foreach (var team in allTeams)
        {
            if (team.league == league)
                teamsInLeague.Add(team);
        }
        return teamsInLeague;
    }

    public void UpdateTeamFormation(string teamId, string newFormation)
    {
        if (teamDictionary.TryGetValue(teamId, out var team))
        {
            team.formation = newFormation;
        }
    }
}