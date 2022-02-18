using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int fuel = 100;
    public float lapProgress;
    public float reqLapProgress = 200f;
    public int laps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check how much fuel,
        // If I still have fuel, increase progression and decrease fuel
        if(fuel > 0)
        {
            //Increase progression
            lapProgress += 5;
            //Decrease fuel
            fuel--;

        }
        else
        {
            //Out of fuel
            Debug.Log("Bad Luck, We're out of fuel");

        }
        // If I have enough progression, count as lap
        if(lapProgress >= reqLapProgress)
        {
            lapProgress = 0;
            laps++;

        }
        Debug.Log("Current Fuel: " + fuel);
        Debug.Log("Current Laps: " + laps);
    }
}
