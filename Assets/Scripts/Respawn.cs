using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject kulaPrefab;
    public Camera cameraPrefab;
    public Light lightPrefab;

    public GameObject gameOverBase;
    public GameObject levelName;
    void Start()
    {
        /*GameObject kula = GameObject.Instantiate(kulaPrefab);
        kula.name = "Kula";
        kula.transform.position = transform.position + Vector3.up*1f;

        Camera camera = GameObject.Instantiate(cameraPrefab);
        CameraContoller cameraContoller = camera.GetComponent<CameraContoller>();
        cameraContoller.Kula = Kula.transfrorm;   */

        Light light = GameObject.Instantiate(lightPrefab);
        light.color = Color.white;
        light.intensity = 0.5f; 
        RenderSettings.ambientLight = Color.white * 0.7f;

        GameObject.Instantiate(gameOverBase);
        GameObject.Instantiate(levelName);  
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
