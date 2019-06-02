using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreenButtons : MonoBehaviour
{
    public GameObject SaveGameScreen;
    public GameObject StartScreen;
    public GameObject ClientBookScreen;
    public GameObject SettingsScreen;

    public void ToSaveGameScreen()
    {
        //If this button is pressed, you get to see the saveGamescreen
        StartScreen.SetActive(false);
        SaveGameScreen.SetActive(true);
    }

    public void ToClientBook()
    {
        SaveGameScreen.SetActive(false);
        ClientBookScreen.SetActive(true);
    }

    public void ToSettings()
    {
        SaveGameScreen.SetActive(false);
        SettingsScreen.SetActive(true);
    }

    public void BackToSaveGameFromCB()
    {
        ClientBookScreen.SetActive(false);
        SaveGameScreen.SetActive(true);
    }

    public void BackToMenu()
    {
        SaveGameScreen.SetActive(false);
        StartScreen.SetActive(true);
    }

    public void BackToSaveFromSettings()
    {
        SettingsScreen.SetActive(false);
        SaveGameScreen.SetActive(true);
    }
}
