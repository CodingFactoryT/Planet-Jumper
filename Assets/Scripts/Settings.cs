using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class Settings : MonoBehaviour
{


    public AudioMixer audiomixer;
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;
    public Dropdown graphicsResolutionDropdown;
    public Slider volumeslider;
    public Toggle FullscreenToggle;

    private void Start()
    {
        volumeslider.GetComponent<Slider>();
        FullscreenToggle.GetComponent<Toggle>();
        graphicsResolutionDropdown.GetComponent<Dropdown>();
        FullscreenToggle.isOn = Screen.fullScreen;
        resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentresolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.width &&
               resolutions[i].height == Screen.height)
            {
                currentresolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentresolutionIndex;
        resolutionDropdown.RefreshShownValue();

        audiomixer.SetFloat("Volume", PlayerPrefs.GetFloat("SettingsVolumeKey", -40));
        volumeslider.value = PlayerPrefs.GetFloat("SettingsVolumeKey", -40);
        graphicsResolutionDropdown.value = PlayerPrefs.GetInt("graphicsDropdownIndexKey", 2);
    }
    

    public void SetVolume(float volumevalue)
    {
        audiomixer.SetFloat("Volume", volumevalue);
        PlayerPrefs.SetFloat("SettingsVolumeKey", volumevalue);
    }

    public void SetQuality(int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
        PlayerPrefs.SetInt("graphicsDropdownIndexKey", qualityindex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetScreenresolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

}
