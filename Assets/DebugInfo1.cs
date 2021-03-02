using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo1 : MonoBehaviour
{
    public Text Spring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.b == 1){
            Spring.text = "Частота колебаний: 8 Гц" + "\nЧастота вращения двигателя: 480 об/мин";
        }
        if(GlobalVariables.b == 2){
            Spring.text = "Частота колебаний: 11 Гц" + "\nЧастота вращения двигателя: 660 об/мин";
        }
        if(GlobalVariables.b == 3){
            Spring.text = "Частота колебаний: 16 Гц" + "\nЧастота вращения двигателя: 960 об/мин";
        }
        if(GlobalVariables.b == 4){
            Spring.text = "Частота колебаний: 22 Гц" + "\nЧастота вращения двигателя: 1320 об/мин";
        }
        if(GlobalVariables.b == 5){
            Spring.text = "Частота колебаний: 32 Гц" + "\nЧастота вращения двигателя: 1920 об/мин";
        }
        if(GlobalVariables.b == 6){
            Spring.text = "Частота колебаний: 44 Гц" + "\nЧастота вращения двигателя: 2640 об/мин";
        }
    }
}
