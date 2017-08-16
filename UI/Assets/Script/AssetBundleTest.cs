using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleTest : MonoBehaviour {

    IEnumerator Start()
    {
        WWW www = new WWW("http://myserver/myBundle.unity3d");
        yield return www;

        // Get the designated main asset and instantiate it.
        Instantiate(www.assetBundle.mainAsset);
    }
}
