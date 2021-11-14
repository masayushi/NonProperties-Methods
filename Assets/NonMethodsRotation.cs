using UnityEngine;

public class NonMethodsRotation : MonoBehaviour
{
    public Transform tra;

    private void Update()
    {
        tra.Rotate(0, 0, 5);
    }
}
