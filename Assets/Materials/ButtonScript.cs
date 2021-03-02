using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    GameObject go;
    int count = 0;
    public void onClick()
    {
        go = GameObject.Find("Main Camera");
        if(count % 2 == 0){
            go.transform.position = new Vector3(8, 8, -37);
            go.transform.rotation = Quaternion.Euler(0, 270, 0);
        }else{
            go.transform.position = new Vector3(41.8f, 24.5f, -0.1f);
        }
        count++;
    }
}
