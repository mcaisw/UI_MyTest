using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YieldReturnStartCoroutine : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(PrintNum());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator PrintNum() {
        yield return StartCoroutine(Count10Times());
        //yield return Count10Times();
        Debug.Log("PrintNum");
    }
    IEnumerator Count10Times() {
        int i=0;
        while (i<10) {
            yield return new WaitForSeconds(1);
            i++;
            Debug.Log(i);
        }
        yield return null;
    }
}

