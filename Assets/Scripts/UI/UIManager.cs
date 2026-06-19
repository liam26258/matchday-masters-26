using UnityEngine;

public class UIManager : MonoBehaviour
{
    private GameObject mainMenuPanel;
    private GameObject matchHUDPanel;
    private GameObject careerHUDPanel;

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        matchHUDPanel.SetActive(false);
        careerHUDPanel.SetActive(false);
    }

    public void ShowMatchHUD()
    {
        mainMenuPanel.SetActive(false);
        matchHUDPanel.SetActive(true);
        careerHUDPanel.SetActive(false);
    }

    public void ShowCareerHUD()
    {
        mainMenuPanel.SetActive(false);
        matchHUDPanel.SetActive(false);
        careerHUDPanel.SetActive(true);
    }

    public void UpdateMatchUI(MatchData match)
    {
        // Update HUD with current match data
    }
}