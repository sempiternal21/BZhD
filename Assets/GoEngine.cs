using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoEngine : MonoBehaviour
{
    int k = 0;
    int j = 0;
    GameObject Spring1;
    GameObject Spring2;
    GameObject Spring3;
    GameObject Spring4;
    // Start is called before the first frame update
    void Start()
    {
        Spring1 = GameObject.Find("default");
        Spring2 = GameObject.Find("default (1)");
        Spring3 = GameObject.Find("default (2)");
        Spring4 = GameObject.Find("default (3)");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (j % 2 == 0)
        {
            if (GlobalVariables.c == 1)
            {
                if (k % 4 == 0)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
                else if (k % 4 == 1)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 2)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 3)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
            }
            if (GlobalVariables.c == 2)
            {
                if (k % 4 == 0)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 0.6f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
                else if (k % 4 == 1)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.6f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 2)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 0.6f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 3)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.6f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
            }


            if (GlobalVariables.c == 3)
            {
                if (k % 4 == 0)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 0.7f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
                else if (k % 4 == 1)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.7f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 2)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.7f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 3)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.7f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
            }


            if (GlobalVariables.c == 4)
            {
                if (k % 4 == 0)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 0.8f - 0.05f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
                else if (k % 4 == 1)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.8f - 0.05f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 2)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 0.8f - 0.05f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 3)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.8f - 0.05f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
            }


            if (GlobalVariables.c == 5)
            {
                if (k % 4 == 0)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 0.9f - 0.05f - 0.05f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
                else if (k % 4 == 1)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.9f - 0.05f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 2)
                {
                    transform.position = new Vector3(-10.06184f, 8.696434f - 0.5f - 0.2f - 0.1f + 0.9f - 0.05f - 0.05f, 15.40842f);
                    transform.Rotate(-2, 0, 0);
                }
                else if (k % 4 == 3)
                {
                    transform.position = new Vector3(-10.06184f, 7.696434f + 0.9f - 0.05f, 15.40842f);
                    transform.Rotate(2, 0, 0);
                }
            }
            k++;
        }
        j++;
        if (k == 100000)
            k = 0;
        if (j == 100000)
            j = 0;
        //Debug.Log(GlobalVariables.b); // x -10.06184 z 15.40842 y 7.696434
    }
}
