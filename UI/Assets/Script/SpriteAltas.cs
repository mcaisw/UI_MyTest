﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class SpriteAltas{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [MenuItem("MyMenu/AtlasMaker")]
    static private void MakeAtlas()
    {
        string spriteDir = Application.dataPath + "/Resources/Sprite";
        Debug.Log("Application.dataPath" + Application.dataPath);
        if (!Directory.Exists(spriteDir))
        {
            Directory.CreateDirectory(spriteDir);
        }

        DirectoryInfo rootDirInfo = new DirectoryInfo(Application.dataPath + "/Atlas");
        foreach (DirectoryInfo dirInfo in rootDirInfo.GetDirectories())
        {
            foreach (FileInfo pngFile in dirInfo.GetFiles("*.png", SearchOption.AllDirectories))
            {
                string allPath = pngFile.FullName;
                string assetPath = allPath.Substring(allPath.IndexOf("Assets"));
                Sprite sprite = AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
                GameObject go = new GameObject(sprite.name);
                go.AddComponent<SpriteRenderer>().sprite = sprite;
                allPath = spriteDir + "/" + sprite.name + ".prefab";
                string prefabPath = allPath.Substring(allPath.IndexOf("Assets"));
                PrefabUtility.CreatePrefab(prefabPath, go);
                GameObject.DestroyImmediate(go);
            }
        }
    }
}
