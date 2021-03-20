using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPlus : MonoBehaviour
{
    GameObject b1;
    GameObject b2;
    GameObject b3;
    GameObject b4;
    GameObject b5;
    GameObject b6;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("click");
        b1 = GameObject.Find("Cube (2)");
        b2 = GameObject.Find("Cube (3)");
        b3 = GameObject.Find("Cube (4)");
        b4 = GameObject.Find("Cube (5)");
        b5 = GameObject.Find("Cube (6)");
        b6 = GameObject.Find("Cube (7)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void func1(){GameObject go;go = GameObject.Find("Line");
    GameObject go1;
    go1 = GameObject.Find("Cube (1)");
        if(GlobalVariables.b != 6){
            GlobalVariables.b++;

        if(GlobalVariables.b == 2){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 18.23693f);
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
        }
        if(GlobalVariables.b == 3){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 16.19452f);
        }
        if(GlobalVariables.b == 4){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 13.94629f);
        }
        if(GlobalVariables.b == 5){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 11.76931f);
        }
        if(GlobalVariables.b == 6){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 9.50525f);
        }


            float b = (float)MathScript.arr[GlobalVariables.c, GlobalVariables.b];
        if(b / GlobalVariables.volt <= 4.17f){
            go.transform.localScale = new Vector3(1.0051f, b / GlobalVariables.volt + 0.1f, -0.032032f);
        }else{
            go.transform.localScale = new Vector3(1.0051f, 4.17f, -0.032032f);
        }
        //Debug.Log(b);

        }
        //Debug.Log(index);
        //GlobalVariables.b = index;
    }

    public void func2(){GameObject go;go = GameObject.Find("Line");GameObject go1;
    go1 = GameObject.Find("Cube (1)");
        if(GlobalVariables.b != 1){
            GlobalVariables.b--;
            float b = (float)MathScript.arr[GlobalVariables.c, GlobalVariables.b];
        if(b / GlobalVariables.volt <= 4.17f){
            go.transform.localScale = new Vector3(1.0051f, b / GlobalVariables.volt + 0.1f, -0.032032f);
        }else{
            go.transform.localScale = new Vector3(1.0051f, 4.17f, -0.032032f);
        }


        if(GlobalVariables.b == 2){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 18.23693f);
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
        }
        if(GlobalVariables.b == 3){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 16.19452f);
        }
        if(GlobalVariables.b == 4){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 13.94629f);
        }
        if(GlobalVariables.b == 5){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 11.76931f);
        }
        if(GlobalVariables.b == 1){
            //Debug.Log(go1.transform.position.z);//20.23184 18.23693 16.19452 13.94629 11.76931 9.50525
            //Debug.Log(go1.transform.position.x);//3.384582
            //Debug.Log(go1.transform.position.y);//8.482458
            go1.transform.position = new Vector3(3.384582f, 8.482458f, 20.23184f);
        }





        Debug.Log(b);
        }
    }
}
