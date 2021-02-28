using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour
{
    public Text Spring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.c != 1)
        {
            int l = GlobalVariables.c-1;
            Spring.text="Выбран амортизатор № " + l.ToString();
        } 
        else
        {
            Spring.text="Амортизатор не установлен";
        }
    }
}
