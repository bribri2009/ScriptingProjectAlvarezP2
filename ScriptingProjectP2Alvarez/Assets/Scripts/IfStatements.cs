using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float CoffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        CoffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (CoffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (CoffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("coffee is just right.");
        }
    }
}
