using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;

            s.source.loop = s.loop;
        }
    }

    private void Start() {
        Play("Music");
    }

    public void Play(string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.Log("Sound: " + name + " could not be found.");
            return;
        }
        s.source.Play();
    }
}
