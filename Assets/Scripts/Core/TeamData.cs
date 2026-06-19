using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class TeamData
{
    public string teamId;
    public string teamName;
    public string league;
    public string country;
    public string formation;
    public List<string> roster;
    public StadiumData stadium;
    public FinancialData financials;
    public TeamStats stats;
}

[System.Serializable]
public class StadiumData
{
    public string stadiumId;
    public string name;
    public int capacity;
    public string location;
}

[System.Serializable]
public class FinancialData
{
    public int budget;
    public int balance;
}

[System.Serializable]
public class TeamStats
{
    public int wins;
    public int losses;
    public int draws;
    public int position;
    public int goalsFor;
    public int goalsAgainst;
}