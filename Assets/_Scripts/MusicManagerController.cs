using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManagerController : MonoBehaviour
{

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont destroy on load " + name);
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnLevelLoaded;
	}

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }

    void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        AudioClip levelMusic = levelMusicChangeArray[scene.buildIndex];
        Debug.Log("Playing clip: " + levelMusic);
        if(levelMusic)
        {
            audioSource.clip = levelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
