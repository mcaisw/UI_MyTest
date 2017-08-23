using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSpritesAtlas : MonoBehaviour {
    void Start()
    {
        CreatImage(loadSprite("tishi5"));
        CreatImage(loadSprite("tishi6"));
    }

    private void CreatImage(Sprite sprite)
    {
        GameObject go = new GameObject(sprite.name);
        go.layer = LayerMask.NameToLayer("UI");
        go.transform.parent = transform;
        go.transform.localScale = Vector3.one;
        Image image = go.AddComponent<Image>();
        image.sprite = sprite;
        image.SetNativeSize();
    }

    private Sprite loadSprite(string spriteName)
    {
        return Resources.Load<GameObject>("Sprite/" + spriteName).GetComponent<SpriteRenderer>().sprite;
    }
}
