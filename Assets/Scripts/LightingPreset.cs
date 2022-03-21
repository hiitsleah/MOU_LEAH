using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Lighting Preset", menuName = "Scriptable/Lighting Preset", order = 1)]
public class LightingPreset : ScriptableObject
{
    public Color BathroomColor;
    public Color AirportColor;
    public Color StudyroomColor;
    public Color LivingroomColor;

    public Color NatureColor;
    public Color SubwayColor;
     public Color DefaulSkyColor;


}
