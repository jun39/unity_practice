using UnityEngine;

public class MathMoveSample : MonoBehaviour
{
    public float currStrength;
    public float maxStrength;
    public float recoveryRate;

    void Update()
    {
        currStrength = Mathf.MoveTowards(currStrength, maxStrength, recoveryRate * Time.deltaTime);
        Debug.Log(currStrength);
    }
}