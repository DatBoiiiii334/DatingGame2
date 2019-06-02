using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats_Manager : MonoBehaviour
{
    public Text LevelText;
    public Text GoldText;
    public Text DayText;
    public Text TimeDisplay;

    public Text MindControl_Text;
    public Text Seduction_Text;
    public Text Lying_Text;

    public Text MindControl_NextLevel;
    public Text Seduction_NextLevel;
    public Text Lying_NextLevel;

    public Slider MindControlSkillSlider;
    public Slider SeductionSkillSlider;
    public Slider LyingSkillSlider;


    private int AmountSkillMindControl;
    private int MaxLevelMindControl;
    private int CurrentMindControlLevel;
    private bool MindControlLevel_1;
    private bool MindControlLevel_2;
    private bool MindControlLevel_3;


    private int AmountSkillSeduction;
    private int CurrentSeductionLevel;
    private int MaxLevelSeduction;
    private bool SeductionLevel_1;
    private bool SeductionLevel_2;
    private bool SeductionLevel_3;

    private int AmountSkillLying;
    private int CurrentLyingLevel;
    private int MaxLevelLying;
    private bool LyingLevel_1;
    private bool LyingLevel_2;
    private bool LyingLevel_3;

    private int PlayerGold;
    private int PlayerLevel;
    private int AmountDays;
    private string[] Times;
    public int CurrentTime;


    void Start()
    {
        PlayerGold = 0;
        PlayerLevel = 0;
        CurrentTime = 0;

        Times = new string[] { "ochtend", "middag","avond", "nacht" };


        //MindControlSlider
        MindControlSkillSlider.minValue = 0;
        MindControlSkillSlider.maxValue = 3;
        MindControlSkillSlider.wholeNumbers = true;
        MindControlSkillSlider.value = 0;

        MaxLevelMindControl = AmountSkillMindControl + 1;

        //SeductionSlider
        SeductionSkillSlider.minValue = 0;
        SeductionSkillSlider.maxValue = 3;
        SeductionSkillSlider.wholeNumbers = true;
        SeductionSkillSlider.value = 0;

        MaxLevelSeduction = AmountSkillSeduction + 1;

        //LyingSlider
        LyingSkillSlider.minValue = 0;
        LyingSkillSlider.maxValue = 3;
        LyingSkillSlider.wholeNumbers = true;
        LyingSkillSlider.value = 0;

        MaxLevelLying = AmountSkillLying + 1;
    }

    void Update()
    {
        if (CurrentTime >= 4) {
            CurrentTime = 0;
            AmountDays += 1; // go to next day
        }

        LevelText.text = PlayerGold + " g";
        GoldText.text = "Level: " + PlayerLevel;
        DayText.text = "Dag: " + AmountDays;
        TimeDisplay.text = Times[CurrentTime];
        MindControl_NextLevel.text = "" + MaxLevelMindControl;
        Seduction_NextLevel.text = "" + MaxLevelSeduction;
        Lying_NextLevel.text = "" + MaxLevelLying;

        //Skills stats
        MindControl_Text.text = ""  + CurrentMindControlLevel;
        Seduction_Text.text = "" + CurrentSeductionLevel;
        Lying_Text.text = "" + CurrentLyingLevel;


        CheckLevelMindControl();
        CheckLevelSeduction();
        CheckLevelLying();


        if(MaxLevelMindControl >= 4) {
            MindControl_NextLevel.text = "max";
        }
        if (MaxLevelSeduction >= 4) {
            Seduction_NextLevel.text = "max";
        }
        if (MaxLevelLying >= 4) {
            Lying_NextLevel.text = "max";
        }



    }


    void CheckLevelMindControl()
    {
        if(AmountSkillMindControl >= 3) {
            MindControlLevel_1 = true;
            if(AmountSkillMindControl >= 6) {
                MindControlLevel_2 = true;
                if (AmountSkillMindControl >= 9) {
                    MindControlLevel_3 = true;
                }
            }
        }
    }

    void CheckLevelSeduction()
    {
        if (AmountSkillSeduction >= 3) {
            SeductionLevel_1 = true;
            if (AmountSkillSeduction >= 6) {
                SeductionLevel_2 = true;
                if (AmountSkillSeduction >= 9) {
                    SeductionLevel_3 = true;
                }
            }
        }
    }

    void CheckLevelLying()
    {
        if (AmountSkillLying >= 3) {
            LyingLevel_1 = true;
            if (AmountSkillLying >= 6) {
                LyingLevel_2 = true;
                if (AmountSkillLying >= 9) {
                    LyingLevel_3 = true;
                }
            }
        }
    }


    public void NextLevel()
    {
        MindControlSkillSlider.value += 1;
        if (MindControlSkillSlider.value == 3) {
            MindControlSkillSlider.value = 0;
            CurrentMindControlLevel += 1;
            MaxLevelMindControl += 1;
        }

        SeductionSkillSlider.value += 1;
        if (SeductionSkillSlider.value == 3) {
            SeductionSkillSlider.value = 0;
            CurrentSeductionLevel += 1;
            MaxLevelSeduction += 1;
        }

        LyingSkillSlider.value += 1;
        if (LyingSkillSlider.value == 3) {
            LyingSkillSlider.value = 0;
            CurrentLyingLevel += 1;
            MaxLevelLying += 1;
        }
    }


    //For the buttons
    public void LevelUpMincontrol()
    {
        AmountSkillMindControl += 1;
        
        NextLevel();
    }

    public void LevelUpSeduction()
    {
        AmountSkillSeduction += 1;
    }

    public void LevelUpLying()
    {
        AmountSkillLying += 1;
    }


}
