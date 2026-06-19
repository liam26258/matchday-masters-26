using UnityEngine;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private List<PlayerData> allPlayers;
    private Dictionary<string, PlayerData> playerDictionary;

    private void Start()
    {
        InitializePlayers();
    }

    private void InitializePlayers()
    {
        playerDictionary = new Dictionary<string, PlayerData>();
        foreach (var player in allPlayers)
        {
            playerDictionary[player.playerId] = player;
        }
    }

    public PlayerData GetPlayer(string playerId)
    {
        return playerDictionary.TryGetValue(playerId, out var player) ? player : null;
    }

    public PlayerData CreateCustomPlayer(string name, string position, PlayerAppearance appearance)
    {
        var newPlayer = new PlayerData
        {
            playerId = System.Guid.NewGuid().ToString(),
            playerName = name,
            position = position,
            appearance = appearance,
            stats = new PlayerStats()
        };
        playerDictionary[newPlayer.playerId] = newPlayer;
        return newPlayer;
    }

    public void UpdatePlayerStats(string playerId, PlayerStats newStats)
    {
        if (playerDictionary.TryGetValue(playerId, out var player))
        {
            player.stats = newStats;
        }
    }
}