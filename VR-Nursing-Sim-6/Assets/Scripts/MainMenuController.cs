using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public UIDocument mainMenuDocument;

    void OnEnable()
    {
        VisualElement root = mainMenuDocument.rootVisualElement;

        Button playButton = root.Q<Button>("Play");
        Button settingsButton = root.Q<Button>("Settings");
        Button quitButton = root.Q<Button>("Quit");

        if (playButton != null)
        {
            playButton.clicked += OnPlayButtonClicked;
        }
        if (settingsButton != null)
        {
            settingsButton.clicked += OnSettingsButtonClicked;
        }
        if (quitButton != null)
        {
            quitButton.clicked += OnQuitButtonClicked;
        }
    }

    void OnDisable()
    {
        VisualElement root = mainMenuDocument.rootVisualElement;
        Button playButton = root.Q<Button>("PlayButton");
        Button settingsButton = root.Q<Button>("SettingsButton");
        Button quitButton = root.Q<Button>("QuitButton");

        if (playButton != null)
        {
            playButton.clicked -= OnPlayButtonClicked;
        }
        if (settingsButton != null)
        {
            settingsButton.clicked -= OnSettingsButtonClicked;
        }
        if (quitButton != null)
        {
            quitButton.clicked -= OnQuitButtonClicked;
        }
    }

    void OnPlayButtonClicked()
    {
        Debug.Log("Play button clicked");
        //TODO
    }

    void OnSettingsButtonClicked()
    {
        Debug.Log("Settings button clicked");
        //TODO
    }

    void OnQuitButtonClicked()
    {
        Debug.Log("Quit button clicked");
        //Application.Quit();
        //TODO
    }
}
