using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerId;
    public string playerName;
    public string position;
    public PlayerStats stats;
    public PlayerAppearance appearance;
    public ContractData contract;
    public CareerData career;
}

[System.Serializable]
public class PlayerStats
{
    public int pace = 75;
    public int shooting = 75;
    public int passing = 75;
    public int dribbling = 75;
    public int defense = 75;
    public int physical = 75;

    public float GetOverallRating()
    {
        return (pace + shooting + passing + dribbling + defense + physical) / 6f;
    }
}

[System.Serializable]
public class PlayerAppearance
{
    public string skinTone;
    public string hairStyle;
    public int shirtNumber;
}

[System.Serializable]
public class ContractData
{
    public string teamId;
    public int salary;
    public int contractYears;
}

[System.Serializable]
public class CareerData
{
    public int level;
    public int xp;
    public int matches;
    public int goals;
    public int assists;
}