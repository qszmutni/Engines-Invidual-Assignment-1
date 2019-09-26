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
    private static extern int wrapperWrite();

    [DllImport(DLL_NAME)]
    private static extern void wrapperRead();

    [DllImport(DLL_NAME)]
    private static extern void wrapperDelete();




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //Save
        {

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
        }

    }
}
