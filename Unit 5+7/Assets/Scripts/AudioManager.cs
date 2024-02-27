using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("----------Audio Source----------")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----------Audio Clip--------------")]
    public AudioClip Beep;
    public AudioClip Fly;
    public AudioClip Space;
    public AudioClip Venus;

    int musicPlaying = 1;


    private static AudioManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        MusicSource.clip = Space;
        MusicSource.Play();
    }

    private void Update()
    {
        if (MusicSource.isPlaying == false)
        {
            musicPlaying = musicPlaying * -1;
            if (musicPlaying == 1)
            {
                MusicSource.clip = Space;
            }
            if (musicPlaying == -1)
            {
                MusicSource.clip = Venus;
            }
            MusicSource.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayFly(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
