using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUIAnd3DObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PointerDownImage() {
        Debug.Log("按下图片");
    }

    public void PointerDown3DObject() {
        Debug.Log("按下3DObject");

    }
    public void PointerDownButton()
    {
        Debug.Log("按下Button");
    }

}
