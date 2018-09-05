using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManagerController levelManager;
    private MusicManagerController musicManager;

	// Use this for initialization
	void Start ()
    {
        musicManager = GameObject.FindObjectOfType<MusicManagerController>();
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
	}

    // Update is called once per frame
    void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
    }

    public void SetDefaults()
    {
        volumeSlider.value = 0.8f;
        difficultySlider.value = 2.0f;
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("Start");
    }
}
