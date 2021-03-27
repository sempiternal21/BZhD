using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoEngine : MonoBehaviour
{
    int k = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(GlobalVariables.c == 1){
            if(k % 2 == 0){
                transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f, 15.40842f);
            }else{
                transform.position = new Vector3(-10.06184f, 7.696434f, 15.40842f);
        }
        }


        if(GlobalVariables.c == 2){
            if(k % 2 == 0){
            transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 1.5f - 0.5f, 15.40842f);
        }else{
             transform.position = new Vector3(-10.06184f, 7.696434f + 1.5f - 0.5f, 15.40842f);
        }
        }


        if(GlobalVariables.c == 3){
            
        }


        if(GlobalVariables.c == 4){
            
        }


        if(GlobalVariables.c == 5){
            
        }


        
        k++;
        Debug.Log(GlobalVariables.b); // x -10.06184 z 15.40842 y 7.696434
    }
}
