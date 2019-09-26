using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTesterScript : MonoBehaviour
{

    const string DLL_NAME = "Tutorial DLL";

    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();

    [DllImport(DLL_NAME)]
    private static extern int wrapperWrite(float x, float y, float z);

    [DllImport(DLL_NAME)]
    private static extern void wrapperRead();

    [DllImport(DLL_NAME)]
    private static extern void wrapperDelete();

    [DllImport(DLL_NAME)]
    private static extern string wrapperGet();

    [DllImport(DLL_NAME)]
    private static extern float wrapperX();

    [DllImport(DLL_NAME)]
    private static extern float wrapperY();

    [DllImport(DLL_NAME)]
    private static extern float wrapperZ();






    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //Save
        {
            wrapperWrite(transform.position.x, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.E)) //Load
        {
            wrapperRead();

            Vector3 newPos = new Vector3(wrapperX(), wrapperY(), wrapperZ());

            transform.position = newPos;

            Debug.Log(wrapperX());
            Debug.Log(wrapperY());
            Debug.Log(wrapperZ());

        }

    }
}
