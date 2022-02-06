# Unity Editor Scripting Example

When Creating an App or a Game in Unity, we often have a situation where we have to create prefabs, create a scriptable object for it, then add a component to the prefab and add the scriptable object reference to it. This has to be done over and over again.  

I created this Custom Window to make the process in a single window. This will be helpful when you need to create 100's of variants of similar type.

[My Portfolio Website](https://jokester00098.github.io).

## Unity Version

**2019.4.35f1**

## How it works

Here I've simple cretaed a custom window called **Food Creator Window.**

Open the Custom Window,

> Window --> Custom Windows --> Food Creator Window

![enter image description here](https://media-exp1.licdn.com/dms/image/C5622AQEy62hW7kxqoQ/feedshare-shrink_800/0/1644170322791?e=1646870400&v=beta&t=9ROtTtcfza29szvqWS9fOAd65NaYL-oLG-Ry6kETLaw)

Then, 
 - Step 1: Drag and Drop a **Prefab** or **Model**.
 - Step 2: Add a **Name**. Now, the **Create** button appears. (In my case I need the prefab and the name)
 - Step 3: Customize the other options as needed.
 - Step 4: Click **Create**.

This will Create a .asset file in the specified folder. Then creates a prefab in the specified folder by adding a component to it and add the reference of the created .asset file in it.


