using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGColor : MonoBehaviour
{
    // variables
    private Color c_target;
    public  Color c_default;
    private Color c_curr;

    private bool changeColor,backToDefaultC;
    private Shader skybox;
    private float speed = 0.8f;
    float startTime;

    //Reference
    [SerializeField] private Light DirectionalLight;
    [SerializeField] public LightingPreset Preset;


    private void OnValidate(){
        DirectionalLight = GameObject.Find("Directional Light").GetComponent<Light>();
        skybox = Shader.Find("customSkybox");
        c_default = Preset.DefaulSkyColor;
        RenderSettings.skybox.SetColor("_Tint", Preset.DefaulSkyColor);
        RenderSettings.ambientLight = Preset.DefaulSkyColor;
        DirectionalLight.color = Preset.DefaulSkyColor;
    }
    void Start()
    { 
        changeColor = false;
        backToDefaultC = false;
        c_curr = c_default;
        
    }

    // Update is called once per frame
    void Update()
    {
        float t_ = (Time.time - startTime) * speed;
        t_ =  Mathf.Clamp(t_, 0.0f, 1.0f);
        float t  = t_;
        if(changeColor) t = t_;
        if(backToDefaultC) t = 1-t_;
        c_curr = Color.Lerp(c_default, c_target, t);
        RenderSettings.skybox.SetColor("_Tint", c_curr);
        RenderSettings.ambientLight = c_curr;
        DirectionalLight.color = c_curr;
    }

   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Area_Studyroom"){
            c_target = Preset.StudyroomColor;
        }
          if(other.gameObject.name == "Area_Livingroom"){
            c_target = Preset.LivingroomColor;
        }
          if(other.gameObject.name == "Area_Airport"){
            c_target = Preset.AirportColor;
        }
          if(other.gameObject.name == "Area_Bathroom"){
            c_target = Preset.BathroomColor;
        }
          if(other.gameObject.name == "Area_Natrue"){
            c_target = Preset.NatureColor;
        }
          if(other.gameObject.name == "Area_Subway"){
            c_target = Preset.SubwayColor;
        }
        if(other.gameObject.CompareTag("Area")){
        Debug.Log("enter");
        startTime = Time.time;
        changeColor = true;
        backToDefaultC = false;
        }
 

    }
       void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Area")){
        Debug.Log("exit");
        startTime = Time.time;
        changeColor = false;
        backToDefaultC = true;
        }
 

    }
   
}
