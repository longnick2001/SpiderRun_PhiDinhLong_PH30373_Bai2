using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_Mapping : MonoBehaviour
{
    public float ScrollSpeed = 0.5f;

    public float offSet;

    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offSet += Time.deltaTime * ScrollSpeed;
        renderer.material.mainTextureOffset = new Vector2(offSet, 0.01f);
    }
}
