using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelsManager : MonoBehaviour
{

    private int Level_0_Complete;
    private int Level_1_Complete;
    private int Level_2_Complete;

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
        
    private void Start()
    {
        // make sure to " PlayerPrefs.SetInt("Level_#_Complete", 1) " On level complete
        Level_0_Complete = PlayerPrefs.GetInt("Level_0_Complete");
        Level_1_Complete = PlayerPrefs.GetInt("Level_1_Complete");
        Level_2_Complete = PlayerPrefs.GetInt("Level_2_Complete");
       

        if (Level_0_Complete != 1)
        {
            Level1.SetActive(false);
        }

        if (Level_0_Complete == 1)
        {
            Level1.SetActive(true);
        }
        
        
        if (Level_1_Complete != 1 )
        {
            Level2.SetActive(false);
        }
        
        if (Level_1_Complete == 1)
        {
            Level2.SetActive(true);
        }
        
        
        
        if (Level_2_Complete != 1 )
        {
            Level3.SetActive(false);
        }
        
        if (Level_2_Complete == 1)
        {
            Level3.SetActive(true);
        }

        else
        {
            return;
        }
        

    }

}
