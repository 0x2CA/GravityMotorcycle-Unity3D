using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour {
    // Start is called before the first frame update

    [SerializeField]
    private Transform target;

    void Start () {
        this.transform.position = new Vector3 (target.position.x, target.position.y, this.transform.position.z);

    }

    // Update is called once per frame
    void Update () {
        this.transform.position = new Vector3 (target.position.x, target.position.y, this.transform.position.z);

    }

}