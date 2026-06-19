using UnityEngine;

public class MatchEngine : MonoBehaviour
{
    private MatchData matchData;
    private BallPhysics ballPhysics;
    private AIController aiController;
    private EventSystem eventSystem;

    private void Awake()
    {
        ballPhysics = GetComponent<BallPhysics>();
        aiController = GetComponent<AIController>();
        eventSystem = GetComponent<EventSystem>();
    }

    public void InitializeMatch(MatchData match)
    {
        matchData = match;
        ballPhysics.Initialize();
        aiController.Initialize(match);
    }

    public void UpdateMatch(float deltaTime)
    {
        ballPhysics.Update(deltaTime);
        aiController.Update(deltaTime);
        CheckForMatchEvents();
    }

    private void CheckForMatchEvents()
    {
        // Goal, foul, injury, substitution checks
    }

    public void FinalizeMatch(MatchData match)
    {
        // Save match results, update player stats, etc
    }
}