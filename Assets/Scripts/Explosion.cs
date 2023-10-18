using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    //[SerializeField] private AudioClip _explosionAudioClip;
    //[SerializeField] private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //_audioSource = GetComponent<AudioSource>();
        //_audioSource.clip = _explosionAudioClip;
        Destroy(this.gameObject, 3f);
       // _audioSource.Play();
    }

}
