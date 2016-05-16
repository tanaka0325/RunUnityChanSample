using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour {
    public void OnTapped() {
        this.GetComponent<Animator>().SetTrigger("Jump");
    }

    public void OnCollidedWithObstacle() {
        this.GetComponent<Animator>().SetTrigger("Collision");
    }

    public void OnCallChangeFace() {
    }
}
