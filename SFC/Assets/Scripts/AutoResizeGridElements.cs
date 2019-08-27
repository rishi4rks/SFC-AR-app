using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoResizeGridElements : MonoBehaviour {
    Canvas canvas;
    GridLayoutGroup gridLayout;
	// Use this for initialization
	void Start () {
        canvas = this.GetComponentInParent<Canvas>();
        gridLayout = this.GetComponent<GridLayoutGroup>();
		
	}
	
	// Update is called once per frame
	void Update () {
        float cellX = canvas.pixelRect.width * 0.1916f;
        float cellY = canvas.pixelRect.height * 0.82f / 3;
        gridLayout.cellSize = new Vector2(cellX, cellY);


    }
}
