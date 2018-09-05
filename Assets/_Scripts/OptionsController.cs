using System.Collections;
using System.Collections.Generic;
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

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("Start");
    }
}
