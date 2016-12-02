using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {


    public void OnCollisionEnter()
    {
        IntegrationTest.Pass();
    }
}
