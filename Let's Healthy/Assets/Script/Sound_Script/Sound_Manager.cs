using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Sound_Manager
{
    public enum Sound
    {
        Button,
        MissionClear,
        MissionFail,
        Item,
        Knife1, 
        Knife2, 
        Knife3,
        BeatEgg,
        TableCloth,
        DropItemPan,
        DropItemPot,
        Water,
        Kek,
        Peep,
        Bar,
        Punch,
        Write,
        Clock,
        Fire,
        Bell,
        Click,
        Powerup
    }

    public static void PlaySound(Sound sound)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        Destroy10sec destroy10Sec = soundGameObject.AddComponent<Destroy10sec>();
        audioSource.PlayOneShot(GetAudioClip(sound));
    }

    public static void PlaySoundDontBye(Sound sound)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));
    }

    static AudioClip GetAudioClip(Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.SoundAudioClipArray)
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("Sound " + sound + " not found!");
        return null;
    }

}

//เวลาใช้ Sound_Manager.PlaySound(Sound_Manager.Sound.ชื่อ Sound);
