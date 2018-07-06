using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicPlaylist : MonoBehaviour
{

    public AudioSource AudioSource;

    public SoundList[] SoundList;

    private int Cu_Song = 0;
    private float Cu_Song_Duration = 0;
    private float Player_Duration = 0;
    private bool DontDoubleDown = true;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        ThisSongPlz();
    }
    void Update()
    {
        Player_Duration = AudioSource.time;

        if (Cu_Song_Duration <= Player_Duration && DontDoubleDown)
        {
            DontDoubleDown = false;
            NextSong(1);
        }
    }

    private void ThisSongPlz()
    {
        AudioSource.clip = SoundList[Cu_Song].clip;
        AudioSource.Play();
        Cu_Song_Duration = SoundList[Cu_Song].clip.length;

        DontDoubleDown = true;
    }

    // FUNCTION TO PAUSE CURRENT SONG
    //public void Pause()
    //{
    //   AudioSource.Pause();
    //}

    // FUNCTION TO UNPAUSE CURRENT SONG
    //public void StartPlaying()
    //{
    //   AudioSource.UnPause();
    //}

    // FUNCTION TO CHANGE THE CURRENT SONG TO THE NEXT OR THE PREVIOUS SONG
    public void NextSong(int SongUpDown)
    {
        if (SongUpDown == 1 && Cu_Song == SoundList.Length - 1) { Cu_Song = 0; }
        else if (SongUpDown == -1 && Cu_Song == 0) { Cu_Song = SoundList.Length - 1; }
        else { Cu_Song += SongUpDown; }

        ThisSongPlz();
    }

}