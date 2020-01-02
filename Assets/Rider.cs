using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rider : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    private void OnCollisionEnter2D (Collision2D other) {
        print (other.gameObject.name);
        if (other.gameObject.tag == "BackGround") {
            SceneManager.LoadScene (0);
        }
    }
}