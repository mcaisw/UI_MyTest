using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YouYoMove : MonoBehaviour {

    Tween t;
    Tween t_b;
    // Use this for initialization
    void Start()
    {
        t = DOTween.To(() => this.transform.position,
                        x => this.transform.position = x,
                        new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z),
                        1).SetDelay(1)
                        .OnComplete(() =>
                        {
                            t_b = DOTween.To(() => this.transform.position,
                               x => this.transform.position = x,
                               new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z),
                               1).SetDelay(1).OnComplete(PlayDotween);
                        }
                         );
    }

    void PlayDotween()
    {
        t = DOTween.To(() => this.transform.position,
                        x => this.transform.position = x,
                        new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z),
                        1).SetDelay(1)
                        .OnComplete(() =>
                        {
                            t_b = DOTween.To(() => this.transform.position,
                               x => this.transform.position = x,
                               new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z),
                               1).SetDelay(1).OnComplete(PlayDotween);
                        }
                         );
    }
}
