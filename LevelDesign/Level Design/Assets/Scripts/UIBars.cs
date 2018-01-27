using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBars : MonoBehaviour {

    public Image currentEnemBar;
    public Image currentHealthBar;
    public Image currentExperienceBar;
    public Text enemRatio;
    public Text healthRatio;
    public Text goldtext;
    public Text experienceRatio;
    public Text levelText;
    public Text experienceValues;
    public Text healthValues;
    public Text enemValues;
    private float enemPoints = 150;
    private float maxEnemPoints = 150;
    private float hitpoint = 150;
    private float maxHitpoints = 150;
    private float gold;
    private float maxExperience = 150F;
    public float currentExperience = 0;
    private float level = 1;
    float exponent = 1.1F;
    public static float currentExpStatic = 0;
    public GameObject SaburaCam;
    public GameObject MotherCam;
    public GameObject Clue1Cam;
    public GameObject Clue2Cam;
    public GameObject Clue3Cam;
    public GameObject Clue4Cam;




    private void Start()
    {
        UpdateEnemBar();
        UpdateHealthBar();
        UpdateGold();
        UpdateExperienceBar();
        UpdateLevel();
    }

    private void UpdateEnemBar()
    {
        float ratioEnem = enemPoints / maxEnemPoints;
        currentEnemBar.rectTransform.localScale = new Vector3(ratioEnem, 1, 1);
        enemRatio.text = (ratioEnem * 100).ToString("0") + '%';
        enemValues.text = enemPoints.ToString("0") + '/' + maxEnemPoints.ToString("0");
       
    }
    private void UpdateHealthBar()
    {
        float ratioHealth = hitpoint / maxHitpoints;
        currentHealthBar.rectTransform.localScale = new Vector3(ratioHealth, 1, 1);
        healthRatio.text = (ratioHealth * 100).ToString("0") + '%';
        healthValues.text = hitpoint.ToString("0") + '/' + maxHitpoints.ToString("0");
    }

    private void UpdateExperienceBar()
    {
        float ratioExperience = currentExperience / maxExperience;
        currentExperienceBar.rectTransform.localScale = new Vector3(ratioExperience, 1, 1);
        experienceRatio.text = (ratioExperience * 100).ToString("0") + '%';
        experienceValues.text = currentExperience.ToString("0") + '/' + maxExperience.ToString("0");

    }


    private void LoseEnem(float loseEnem)
    {
        enemPoints -= loseEnem;
        if (enemPoints < 0)
        {
            enemPoints = 0;
            float damage = Time.deltaTime * 10;
            TakeDamage(damage);
            Debug.Log("You have no Enem!");
        }
        UpdateEnemBar();
    }

    private void GainEnem(float gainEnem)
    {
        enemPoints += gainEnem;
        if (enemPoints > maxEnemPoints)
        {
            enemPoints = maxEnemPoints;

        }
        UpdateEnemBar();
    }
    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("You died!");
        }
        UpdateHealthBar();
    }

    private void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoints)
        {
            hitpoint = maxHitpoints;

        }
        UpdateHealthBar();
    }

     void Update()
    {
        
        if (enemPoints == 0) 
        hitpoint -= Time.deltaTime * 10;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("You died!");
        }
        UpdateHealthBar();
        currentExperience =  currentExperience + currentExpStatic;
        currentExpStatic = 0;
        UpdateExperienceBar();
        deactivateCams();
    }
 

    private void UpdateGold()
    {
        goldtext.text = gold.ToString("0");
    }

    private void UpdateLevel()
    {
        levelText.text = level.ToString("0");
    }

    private void LoseGold(float goldLose)
    {
        gold -= goldLose;
        UpdateGold();
        if (gold < 0)
        {
            gold = 0;
            Debug.Log("You have no Gold!");
        }
    }

    private void GainGold(float goldGain)
    {
        gold += goldGain;
        UpdateGold();
    }

    private void GainExperience(float experienceGain)
    {
        currentExperience += experienceGain;
        
        if (currentExperience > maxExperience)
        {
            
            float restExperience = Math.Abs(maxExperience - currentExperience);
            level = level + 1;
            maxExperience = maxExperience * exponent;
            exponent = exponent + 0.015F;
            currentExperience = restExperience;



        }
        UpdateExperienceBar();
        UpdateLevel();
    }
    public static void upExp(float exp)
    {
        currentExpStatic = currentExpStatic + exp;
    }

    private void deactivateCams()
    {
        SaburaCam.SetActive(false);
        MotherCam.SetActive(false);
        Clue1Cam.SetActive(false);
        Clue2Cam.SetActive(false);
        Clue3Cam.SetActive(false);
        Clue4Cam.SetActive(false);
    }
}
