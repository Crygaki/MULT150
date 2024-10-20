using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //Extra Credit
    void ToggleAudio()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(audioSource.isPlaying == true)
                audioSource.Stop();
            else
                audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        ToggleAudio(); //Extra Credit
    }
}
