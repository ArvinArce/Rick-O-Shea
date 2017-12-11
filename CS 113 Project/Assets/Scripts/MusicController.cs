using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	AudioSource audioSource;
    public AudioClip introStartClip;
    public AudioClip introLoopClip;

    private static MusicController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(playIntroSound());
    }

    IEnumerator playIntroSound()
    {
        audioSource.clip = introStartClip;
        audioSource.loop = false;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        audioSource.clip = introLoopClip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
