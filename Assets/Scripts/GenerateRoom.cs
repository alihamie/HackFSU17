using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRoom : MonoBehaviour {

    public GameObject tilePrefab;

    // public string url = "http://www.google.com";
    public string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
    void Start() {

        StartCoroutine(getWeb());
    }

    IEnumerator getWeb()
    {
        WWW www = new WWW(url);
        yield return www;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = www.texture;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
