using UnityEditor;
using UnityEngine;

public class CreateCustomWindow : EditorWindow
{
    Texture2D headerSectionTexture;
    Texture2D iceCreamSectionTexture;
    Texture2D mcHappyMealSectionTexture;
    Texture2D melonCakeSectionTexture;
    Texture2D milkShakeSectionTexture;
    Texture2D puddingSectionTexture;
    Texture2D ramenSectionTexture;

    Color headerSectionColor = new Color(217f / 255f, 215f / 255f, 241f / 255f, 1f);
    Color theme1 = new Color(247f / 255f, 219f / 255f, 240f / 255f, 1);
    Color theme2 = new Color(205f / 255f, 240f / 255f, 234f / 255f, 1);
    Color theme3 = new Color(255f / 255f, 203f / 255f, 203f / 255f, 1);
    Color theme4 = new Color(249f / 255f, 249f / 255f, 249f / 255f, 1);
    Color theme5 = new Color(231f / 255f, 251f / 255f, 190f / 255f, 1);
    Color theme6 = new Color(255f / 255f, 253f / 255f, 222f / 255f, 1);

    Rect headerSection;
    Rect iceCreamSection;
    Rect mcHappyMealSection;
    Rect melonCakeSection;
    Rect milkShakeSection;
    Rect puddingSection;
    Rect ramenSection;


    [MenuItem("Window/Custom Windows/Food Creator Window")]
    static void CreateWindow()
    {
        CreateCustomWindow customWindow = (CreateCustomWindow)GetWindow(typeof(CreateCustomWindow));
        customWindow.titleContent = new GUIContent("Food Creator Window", "You can create food items using this window.");
        customWindow.minSize = new Vector2(600, 450); //set window minimum size
        //customWindow.maxSize = new Vector2(600, 450); //set window maximum size
        customWindow.Show();
    }

    /// <summary>
    /// Similar to Start() or Awake()
    /// </summary>
    private void OnEnable()
    {
        InitTexture();
    }

    /// <summary>
    /// Initialize Texture Values
    /// </summary>
    private void InitTexture()
    {
        headerSectionTexture = new Texture2D(1, 1);
        headerSectionTexture.SetPixel(0, 0, headerSectionColor);
        headerSectionTexture.Apply();

        iceCreamSectionTexture = new Texture2D(1, 1);
        iceCreamSectionTexture.SetPixel(0, 0, theme1);
        iceCreamSectionTexture.Apply();

        mcHappyMealSectionTexture = new Texture2D(1, 1);
        mcHappyMealSectionTexture.SetPixel(0, 0, theme2);
        mcHappyMealSectionTexture.Apply();

        melonCakeSectionTexture = new Texture2D(1, 1);
        melonCakeSectionTexture.SetPixel(0, 0, theme3);
        melonCakeSectionTexture.Apply();

        milkShakeSectionTexture = new Texture2D(1, 1);
        milkShakeSectionTexture.SetPixel(0, 0, theme4);
        milkShakeSectionTexture.Apply();

        puddingSectionTexture = new Texture2D(1, 1);
        puddingSectionTexture.SetPixel(0, 0, theme5);
        puddingSectionTexture.Apply();

        ramenSectionTexture = new Texture2D(1, 1);
        ramenSectionTexture.SetPixel(0, 0, theme6);
        ramenSectionTexture.Apply();

        /*
        //Apply Textures
        iceCreamSectionTexture = Resources.Load<Texture2D>("Icons/IceCream");
        mcHappyMealSectionTexture = Resources.Load<Texture2D>("Icons/McHappyMeal");
        melonCakeSectionTexture = Resources.Load<Texture2D>("Icons/MelonCake");
        milkShakeSectionTexture = Resources.Load<Texture2D>("Icons/MilkShake");
        puddingSectionTexture = Resources.Load<Texture2D>("Icons/Pudding");
        ramenSectionTexture = Resources.Load<Texture2D>("Icons/ramen");
        */
    }

    /// <summary>
    /// Similar to Update()
    /// Not Called per frame. Called 1 or more times per interaction
    /// </summary>
    private void OnGUI()
    {
        DrawLayouts();
        DrawHeader();
        DrawIceCreamSettings();
        DrawMcHappyMealSettings();
        DrawMelonCakeSettings();
        DrawMilkShakeSetttings();
        DrawPuddingSettings();
        DrawRamenSettings();
    }

    /// <summary>
    /// Defines Rect Values and paint textures based on Rects
    /// </summary>
    private void DrawLayouts()
    {
        headerSection.x = 0; headerSection.y = 0;
        headerSection.width = Screen.width;
        headerSection.height = 50;

        iceCreamSection.x = 0; iceCreamSection.y = 50;
        iceCreamSection.width = Screen.width/ 3;
        iceCreamSection.height = (Screen.height - 50) / 2;

        mcHappyMealSection.x = Screen.width / 3; mcHappyMealSection.y = 50;
        mcHappyMealSection.width = Screen.width / 3;
        mcHappyMealSection.height = (Screen.height - 50) / 2;

        melonCakeSection.x = Screen.width / 3 * 2; melonCakeSection.y = 50;
        melonCakeSection.width = Screen.width / 3;
        melonCakeSection.height = (Screen.height - 50) / 2;

        milkShakeSection.x = 0; milkShakeSection.y = (Screen.height + 50) / 2;
        milkShakeSection.width = Screen.width / 3;
        milkShakeSection.height = (Screen.height - 50) / 2;

        puddingSection.x = Screen.width / 3; puddingSection.y = (Screen.height + 50) / 2;
        puddingSection.width = Screen.width / 3;
        puddingSection.height = (Screen.height - 50) / 2;

        ramenSection.x = Screen.width / 3 * 2; ramenSection.y = (Screen.height + 50) / 2;
        ramenSection.width = Screen.width / 3;
        ramenSection.height = (Screen.height - 50) / 2;

        GUI.DrawTexture(headerSection, headerSectionTexture);
        GUI.DrawTexture(iceCreamSection, iceCreamSectionTexture);
        GUI.DrawTexture(mcHappyMealSection, mcHappyMealSectionTexture);
        GUI.DrawTexture(melonCakeSection, melonCakeSectionTexture);
        GUI.DrawTexture(milkShakeSection, milkShakeSectionTexture);
        GUI.DrawTexture(puddingSection, puddingSectionTexture);
        GUI.DrawTexture(ramenSection, ramenSectionTexture);
    }

    /// <summary>
    /// Draw content of header
    /// </summary>
    private void DrawHeader()
    {
        GUILayout.BeginArea(headerSection);


        GUILayout.EndArea();
    }

    /// <summary>
    /// Draw content of IceCream
    /// </summary>
    private void DrawIceCreamSettings()
    {

    }

    /// <summary>
    /// Draw content of McHappyMeal
    /// </summary>
    private void DrawMcHappyMealSettings()
    {

    }

    /// <summary>
    /// Draw content of MelonCake
    /// </summary>
    private void DrawMelonCakeSettings()
    {

    }

    /// <summary>
    /// Draw content of MilkShake
    /// </summary>
    private void DrawMilkShakeSetttings()
    {

    }

    /// <summary>
    /// Draw content of Pudding
    /// </summary>
    private void DrawPuddingSettings()
    {

    }

    /// <summary>
    /// Draw content of Ramen
    /// </summary>
    private void DrawRamenSettings()
    {

    }
}
