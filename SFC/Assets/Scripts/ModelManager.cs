using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour {

    public GameObject[] Models;
    private void Start()
    {
        //Disable all models at start
        DisableAll();
    }
    void DisableAll()
    {
        foreach (var item in Models)
        {
            item.SetActive(false);
        }
    }
    void SetModel(int index)
    {
        //Disable all other models before enabling a model
        DisableAll();
        Models[index].SetActive(true);
    }
}
