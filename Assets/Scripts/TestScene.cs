using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestScene : MonoBehaviour {

    public int planetCount;
    public float minScale;
    public float maxScale;
    public Vector3 extents;

    private List<GameObject> planets;

    // Use this for initialization
    void Start() {
        this.planets = new List<GameObject>();
        for (int i = 0; i < planetCount; i++) {
            GameObject go = new GameObject("Planet " + i);
            planets.Add(go);
            Planet p = go.AddComponent<Planet>();
            p.subdivisionLevel = Random.Range(100, 100);
            p.plateCount = (int)Mathf.Floor(p.subdivisionLevel * Random.Range(.2f, 2f));
            go.transform.position = new Vector3(Random.Range(-extents.x, extents.x), Random.Range(-extents.y, extents.y), Random.Range(-extents.z, -extents.z));
            float scale = Random.Range(minScale, maxScale);
            go.transform.localScale = Vector3.one * scale;
            p.Generate();
        }


    }

    // Update is called once per frame
    void Update() {



    }
}
