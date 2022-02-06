using UnityEngine;
using Types;

[CreateAssetMenuAttribute(fileName ="Food Data", menuName ="Scriptable Object/Food Data")]
public class FoodData : ScriptableObject
{
    public GameObject prefab;
    public new string name;
    public Sprite thumbnail;
    public FoodType foodType;
    public FoodTaste foodTaste;
    public EatingStyle eatingStyle;
    public int calories;
    public float protein;
    public float fat;
}
