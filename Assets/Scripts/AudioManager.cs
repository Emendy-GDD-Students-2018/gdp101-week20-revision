using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	public static AudioManager instance;

	public AudioMixer mixer;

	public string masterVolume = "Master";
	public string musicVolume = "Music";
	public string ambientVolume = "Ambient";
	public string sfxVolume = "SFX";

	private void Awake()
	{
		if (instance==null)
		{
			instance = this;
		}
		else
		{
			Destroy(this.gameObject);
		}
	}

	private void SetGroupVolume(string channelName, float volume)
	{
		float linearVolume = Mathf.Log(volume) * 20f;
		mixer.SetFloat(channelName, linearVolume);
	}

	public void SetMasterVolume(float volume)
	{
		SetGroupVolume(masterVolume, volume);
	}
	public void SetMusicVolume(float volume)
	{
		SetGroupVolume(musicVolume, volume);
	}
	public void SetAmbientVolume(float volume)
	{
		SetGroupVolume(ambientVolume, volume);
	}
	public void SetSFXVolume(float volume)
	{
		SetGroupVolume(sfxVolume, volume);
	}
}
