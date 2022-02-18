using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
// KEYBINDS: Attack: A, level up = L, show stats = s
{
    public int level; //laps
    public float curExp; //curLapProgress
    public float reqExp; //reqLapProgress
    //Stats
    public float health;
    public float defense;
    public float speed;
    public float attack;
    public float enemyHealth;
    public float defaultEnemyHealth;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

        public void InitialStats()
    {
        //setup our stats, level, curexp, reqexp, etc.
        level = 1;
        curExp = 0;
        reqExp = 100;

        health = 20;
        defense = 4;
        speed = 6;
        attack = 6;

        defaultEnemyHealth = 20;
        enemyHealth = 20;
    }

    public void Interaction(float earnedExp)
    {
        //this is called by button press, should grant a diff amount of exp
    }

    public void GainExp(float gain)
    {
        // Attack an enemy
        if (Input.GetKeyDown(KeyCode.A))
        {
            enemyHealth -= attack;
            Debug.Log("The enemy's health is now " + enemyHealth + "HP");

        }
        if (enemyHealth <= 0)
        {
            Debug.Log("The enemy has now died!");
            enemyHealth = defaultEnemyHealth;
        }

    }

    public void LevelUp()
    {
        //increase our level

        //increase enemy health
        defaultEnemyHealth = 20 / defense * speed;

    }

    public void IncreaseStats()
    {
        //increase our various stats

    }
}