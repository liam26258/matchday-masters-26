using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private PlayerManager playerManager;
    private TeamManager teamManager;
    private MatchManager matchManager;
    private CareerManager careerManager;
    private UIManager uiManager;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        InitializeManagers();
    }

    private void InitializeManagers()
    {
        playerManager = GetComponent<PlayerManager>();
        teamManager = GetComponent<TeamManager>();
        matchManager = GetComponent<MatchManager>();
        careerManager = GetComponent<CareerManager>();
        uiManager = GetComponent<UIManager>();
    }

    public PlayerManager GetPlayerManager() => playerManager;
    public TeamManager GetTeamManager() => teamManager;
    public MatchManager GetMatchManager() => matchManager;
    public CareerManager GetCareerManager() => careerManager;
    public UIManager GetUIManager() => uiManager;
}