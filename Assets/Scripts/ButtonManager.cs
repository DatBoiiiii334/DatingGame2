using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject SoundScreen;
    private bool _SoundScreenOn;

    public GameObject ControlScreen;
    private bool _ControlScreenOn;

    public GameObject SkillScreen;
    public GameObject MapScreen;


    public void SoundClick()
    {
        if (!_SoundScreenOn) {
            _SoundScreenOn = true;
            SoundScreen.SetActive(true);
        }
        else {
            _SoundScreenOn = false;
            SoundScreen.SetActive(false);
        }
    }

    public void ControlClick()
    {
        if (!_ControlScreenOn) {
            _ControlScreenOn = true;
            ControlScreen.SetActive(true);
        }
        else {
            _ControlScreenOn = false;
            ControlScreen.SetActive(false);
        }
    }

    public void SkillScreenClick()
    {
        SkillScreen.SetActive(true);
    }

    public void SkillScreenBack()
    {
        SkillScreen.SetActive(false);
    }

    public void MapScreenClick()
    {
        MapScreen.SetActive(true);
    }

    public void MapScreenBack()
    {
        MapScreen.SetActive(false);
    }
}
