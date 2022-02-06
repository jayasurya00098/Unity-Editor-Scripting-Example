using UnityEditor;
using UnityEngine;
using Types;

public class CreateCustomWindow : EditorWindow
{
    Texture2D headerSectionTexture;
    Texture2D headerIconTexture;
    Texture2D foodSectionTexture;

    Rect headerSection;
    Rect headerIconSection;
    Rect foodSection;

    GUISkin guiSkin;

    FoodData foodData;
    public FoodData FoodInfo { get { return foodData; } }

    //icon size, x and y offsets
    float iconSize = 40;
    float x_offset = 55;
    float y_offset = 3;

    [MenuItem("Window/Custom Windows/Food Creator Window")]
    static void CreateWindow()
    {
        CreateCustomWindow customWindow = (CreateCustomWindow)GetWindow(typeof(CreateCustomWindow));
        customWindow.titleContent = new GUIContent("Food Creator Window", "You can create food items using this window.");

        //To Disable Scaling of the Window I've added minSize & maxSize to be same.
        customWindow.minSize = new Vector2(300, 290); //set window minimum size
        customWindow.maxSize = new Vector2(300, 290); //set window maximum size

        customWindow.Show();
    }

    /// <summary>
    /// Similar to Start() or Awake()
    /// </summary>
    private void OnEnable()
    {
        InitTexture();
        InitData();

        //get skin
        guiSkin = Resources.Load<GUISkin>("GUIStyles/FoodCreatorStyle");
    }

    public void InitData()
    {
        foodData = (FoodData)ScriptableObject.CreateInstance(typeof(FoodData));
    }

    /// <summary>
    /// Initialize Texture Values
    /// </summary>
    private void InitTexture()
    {
        //Apply Textures from Resources Folder
        headerSectionTexture = Resources.Load<Texture2D>("Icons/Solid");

        //Apply Textures from Resources Folder
        headerIconTexture = Resources.Load<Texture2D>("Icons/Food_Icon");

        //Apply Textures from Resources Folder
        foodSectionTexture = Resources.Load<Texture2D>("Icons/Gradient");
    }

    /// <summary>
    /// Similar to Update()
    /// Not Called per frame. Called 1 or more times per interaction
    /// </summary>
    private void OnGUI()
    {
        DrawLayouts();
        DrawHeader();
        DrawFoodSettings();
    }

    /// <summary>
    /// Defines Rect Values and paint textures based on Rects
    /// </summary>
    private void DrawLayouts()
    {
        //set header section position, width and height
        headerSection.x = 0; headerSection.y = 0;
        headerSection.width = Screen.width;
        headerSection.height = 50;
        //set header icon section position, width and height
        headerIconSection.x = headerSection.width / 2 + x_offset;
        headerIconSection.y = y_offset;
        headerIconSection.width = headerIconSection.height = iconSize;
        //set food section position, width and height
        foodSection.x = 0; foodSection.y = 50;
        foodSection.width = Screen.width;
        foodSection.height = (Screen.height - 50);
        //draw both header section and food section
        GUI.DrawTexture(headerSection, headerSectionTexture);
        GUI.DrawTexture(headerIconSection, headerIconTexture);
        GUI.DrawTexture(foodSection, foodSectionTexture);
    }

    /// <summary>
    /// Draw content of header
    /// </summary>
    private void DrawHeader()
    {
        GUILayout.BeginArea(headerSection);
        GUILayout.Label("Food Creator", guiSkin.GetStyle("Header"));
        GUILayout.EndArea();
    }

    /// <summary>
    /// Draw content of IceCream
    /// </summary>
    private void DrawFoodSettings()
    {
        GUILayout.BeginArea(foodSection);

        //prefab field
        GUILayout.BeginHorizontal();
        GUILayout.Label("PREFAB:*", guiSkin.GetStyle("FoodHeader"));
        foodData.prefab = (GameObject)EditorGUILayout.ObjectField(foodData.prefab, typeof(GameObject), false);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //name field
        GUILayout.BeginHorizontal();
        GUILayout.Label("NAME:*", guiSkin.GetStyle("FoodHeader"));
        foodData.name = (string)EditorGUILayout.TextField(foodData.name);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //thumbnail field
        GUILayout.BeginHorizontal();
        GUILayout.Label("THUMBNAIL:", guiSkin.GetStyle("FoodHeader"));
        foodData.thumbnail = (Sprite)EditorGUILayout.ObjectField(foodData.thumbnail, typeof(Sprite), false);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //food type
        GUILayout.BeginHorizontal();
        GUILayout.Label("FOOD TYPE:", guiSkin.GetStyle("FoodHeader"));
        foodData.foodType = (FoodType)EditorGUILayout.EnumPopup(foodData.foodType);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //food taste
        GUILayout.BeginHorizontal();
        GUILayout.Label("FOOD TASTE:", guiSkin.GetStyle("FoodHeader"));
        foodData.foodTaste = (FoodTaste)EditorGUILayout.EnumPopup(foodData.foodTaste);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //eating style
        GUILayout.BeginHorizontal();
        GUILayout.Label("EATING STYLE:", guiSkin.GetStyle("FoodHeader"));
        foodData.eatingStyle = (EatingStyle)EditorGUILayout.EnumPopup(foodData.eatingStyle);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //calories field
        GUILayout.BeginHorizontal();
        GUILayout.Label("CALORIES:", guiSkin.GetStyle("FoodHeader"));
        foodData.calories = (int)EditorGUILayout.IntField(foodData.calories);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //protein field
        GUILayout.BeginHorizontal();
        GUILayout.Label("PROTEIN:", guiSkin.GetStyle("FoodHeader"));
        foodData.protein = (float)EditorGUILayout.Slider(foodData.protein, 0, 100);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(3f);

        //fat field
        GUILayout.BeginHorizontal();
        GUILayout.Label("FAT:", guiSkin.GetStyle("FoodHeader"));
        foodData.fat = (float)EditorGUILayout.Slider(foodData.fat, 0, 100);
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.Space(10f);

        GUILayout.BeginHorizontal();
        GUILayout.Space(10f);
        //help box for Empty Prefab
        if (foodData.prefab == null)
        {
            EditorGUILayout.HelpBox("Please Add a [Prefab]", MessageType.Warning);
        }
        //help box for Empty Name
        else if (foodData.name == null || foodData.name.Length < 1)
        {
            EditorGUILayout.HelpBox("Please Add a [Name]", MessageType.Warning);
        }
        //when both name and prefab available creates button
        else if (GUILayout.Button("Create", GUILayout.Height(30)))
        {
            SaveAndExport();
        }
        GUILayout.Space(10f);
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }

    /// <summary>
    /// Creates a copy of prefab, creates and adds a .asset file to the prefab
    /// </summary>
    void SaveAndExport()
    {
        string prefabPath;
        string newPrefabPath = "Assets/Prefabs/Food/";
        string dataPath = "Assets/Resources/FoodData/Data/";

        dataPath += FoodInfo.name + ".asset";

        AssetDatabase.CreateAsset(FoodInfo, dataPath);

        newPrefabPath += FoodInfo.name + ".prefab";

        prefabPath = AssetDatabase.GetAssetPath(FoodInfo.prefab);

        AssetDatabase.CopyAsset(prefabPath, newPrefabPath);

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        GameObject foodPrefab = (GameObject)AssetDatabase.LoadAssetAtPath(newPrefabPath, typeof(GameObject));
        if (!foodPrefab.GetComponent<Food>())
        {
            foodPrefab.AddComponent(typeof(Food));
        }

        foodPrefab.GetComponent<Food>().data = FoodInfo;

        Debug.Log("Created " + " .asset at " + dataPath + " || " + "Created " + " .prefab at " + newPrefabPath);

        ResetValues();
    }

    void ResetValues()
    {
        //createing another instance of scriptable object to avoid Create Asset issue
        foodData = (FoodData)ScriptableObject.CreateInstance(typeof(FoodData));
        //Resetting Food Info Values
        FoodInfo.prefab = null;
        FoodInfo.name = "";
        FoodInfo.thumbnail = null;
        FoodInfo.foodType = FoodType.VEG;
        FoodInfo.foodTaste = FoodTaste.SWEET;
        FoodInfo.calories = 0;
        FoodInfo.protein = 0f;
        FoodInfo.fat = 0f;
    }
}
