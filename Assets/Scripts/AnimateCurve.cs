using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Components;

public class AnimateCurve : MonoBehaviour
{
    public BGCcCursorObjectTranslate translate;
    public float speed = .5f;

    void Update()
    {

        translate.Cursor.DistanceRatio = Mathf.MoveTowards(translate.Cursor.DistanceRatio, 1, speed * Time.deltaTime);

        if (translate.Cursor.DistanceRatio == 1)
            translate.Cursor.DistanceRatio = 0;
    }
}
