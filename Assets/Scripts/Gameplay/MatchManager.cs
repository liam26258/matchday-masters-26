using UnityEngine;

public class MatchManager : MonoBehaviour
{
    private MatchData currentMatch;
    private MatchEngine matchEngine;
    private bool isMatchActive;
    private float matchTimer;

    private void Start()
    {
        matchEngine = GetComponent<MatchEngine>();
    }

    public void StartMatch(MatchData matchData)
    {
        currentMatch = matchData;
        isMatchActive = true;
        matchTimer = 0f;
        matchEngine.InitializeMatch(matchData);
    }

    private void Update()
    {
        if (isMatchActive)
        {
            matchTimer += Time.deltaTime;
            matchEngine.UpdateMatch(Time.deltaTime);
            
            if (matchTimer >= 5400f) // 90 minutes in seconds
            {
                EndMatch();
            }
        }
    }

    public void EndMatch()
    {
        isMatchActive = false;
        matchEngine.FinalizeMatch(currentMatch);
    }

    public MatchData GetCurrentMatch() => currentMatch;
    public bool IsMatchActive() => isMatchActive;
    public float GetMatchTime() => matchTimer;
}