using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POS : MonoBehaviour
{
    static float minAngle = -270f;
    static float maxAngle = -450f;
    static POS dialPosition;

    // Use this for initialization
    void Start()
    {
        dialPosition = this;
    }

    public static void showDialPosition(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        dialPosition.transform.eulerAngles = new Vector3(0, 0, ang);
    }
}
