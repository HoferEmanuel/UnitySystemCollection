# InputManager
**using Unity´s new Input-System**

<hr />

## Setup:
1. Install Unity-Package
    - install the new Input-System in your Unity-Editor. 
    - **In Unity-Editor: Window > PackageManager > UnityRegistry > install Input System > restart Editor**
    
    
    > if you´re having problems check if <ins> **Both/InputSystemPackage** </ins> is selected under **In nity-Editor: Edit > ProjectsSettings > Player > Other Settings > Active Input Handling**

2. Setup InputActions
    - RightClick inside Assets-Folder > Create > InputActions (I called mine **"PlayerInputActions"**)
    - Setup your Contol Schemes and Actions as you wish

3. Create a Reference to the InputActions
    - Click on your InputActions
    - Inside the Inspector toggle on **"Generate C# Script"** > Apply
