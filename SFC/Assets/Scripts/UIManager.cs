using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public GameObject ModelsManager;
    public Sprite[] SelectedSprites;
    public Sprite[] NormalSprites;
    public Image[] SliderImages;
    // Use this for initialization
    void Start () {
        DeselectAll();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectModel(int index)
    {
        ModelsManager.SendMessage("SetModel", (index));
        //Set all images to be deselected
        DeselectAll();
        SliderImages[index].sprite = SelectedSprites[index];
    }

    void DeselectAll()
    {
        for (int i = 0; i < SliderImages.Length; i++)
        {
            SliderImages[i].sprite = NormalSprites[i];
        }
    }
}
