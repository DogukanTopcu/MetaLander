using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private bool isOpen = false;
    public GameObject bigMap;
    public GameObject miniMap;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            OpenMap();
        }
    }

    void OpenMap(){
        if (isOpen == false)
        {
            bigMap.SetActive(true);
            miniMap.SetActive(false);
            isOpen = true;
        }
        else
        {
            bigMap.SetActive(false);
            miniMap.SetActive(true);
            isOpen = false;
        }
    }
}
