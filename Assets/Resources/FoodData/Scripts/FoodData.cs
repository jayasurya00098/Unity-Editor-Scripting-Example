using UnityEngine;
using Types;

[CreateAssetMenuAttribute(fileName ="Food Data", menuName ="Scriptable Object/Food Data")]
public class FoodData : ScriptableObject
{
    public GameObject prefab;
    public FoodType foodType;
    public FoodTaste foodTaste;
    public EatingStyle eatingStyle;
    public int calories;
}
