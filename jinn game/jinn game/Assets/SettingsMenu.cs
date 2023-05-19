using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    

    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start()
    {
           resolutions = SetFullscreen.resolution;

            resolutionDropdown.ClearOptions();

            List<string> options = new List<string>();

            int currentResolutionindex = 0;

            for (int i = 0; i < resolutions.Length; i++)
            {
                string option = resolutions[i].width + "x" + resolutions[i].height;
                options.Add(option);

                if(resolutions[i].width == Screen.currentResolution.width && 
                    resolutions[i].height == Screen.currentResolution.)
                {
                    
                    currentResolutionindex = i;

                }
            }

            resolutionDropdown.addOptions(options);
            resolutionDropdown.value = currentResolutionindex;
            resolutionDropdown.RefreshShownValue();
    }

    public void SetVolume(float volume)
    
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }


}
