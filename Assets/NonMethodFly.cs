using UnityEngine;

public class NonMethodFly : MonoBehaviour
{
    private Rigidbody2D rig;

    private void Update()
    {
        rig = GetComponent<Rigidbody2D>();


        rig.position = new Vector2(0, 5);
    }
}
