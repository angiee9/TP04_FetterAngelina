using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button backButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settings;

    public Slider musicSlider;

    private void Awake()
    {
        Time.timeScale = 0;
        playButton.onClick.AddListener(OnPlayButtonClicked);
        backButton.onClick.AddListener(OnBackButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnBackButtonClicked()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }

    private void OnSettingsButtonClicked()
    {
        settings.SetActive(true);
        mainMenu.SetActive(false);
    }

}
