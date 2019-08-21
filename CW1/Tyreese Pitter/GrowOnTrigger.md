# How to make the player grow after item pick up

This will show you how to make the player grow once all coins are collected. Before starting, the Item Collection and the Item Counter scripts need to be made first. Refer to both gists if needed.

## Creating the script

In your Scene, Select the player cube, and in the settings, press Add Component > New Script. Name the script "GrowOntrigger".

Right click the script and press Edit Script.

Under `public class GrowOnTrigger : MonoBehaviour {`, create 1 float named "ScaX", 1 float named "ScaY", 1 float named "speed" with a Value of 1F, and a public CountObjects variable named "Script", this will call up the CountObjects script when applied in Unity. 

Save the script and go back to Unity. On the right side of the screen, where it says "Script" in the scripts settings, press the small circle beside it. This will bring up a small window. Click on "EventSystem".

Under `void Start ()` type in `ScaX = transform.localScale.x;`, this links the variable `ScaX` to the Scale attribute of the gameobject on the x axis. Do the same to the `ScaY` variable, but replace `localscale.x` with `localscale.y`.

Under `void Update () {` type `if` and press TAB twice to autocomplete the statement. in the brackets, type `Collect.objects == 0`. under that, write the following:
```
transform.localScale = new Vector3 (ScaX, ScaY, 0);
			ScaX += speed;
			ScaY += speed;
```
This states that if the amount of objects left goes down to zero, the player will grow by how much the value of `speed` is, however, they will keep growing. This is where you add another if statement. 

Type `if` and press TAB twice,

In the brackets, type in one of the two statements,
```
ScaX > 2;
```
OR
```
ScaY > 2;
```
Under this, type `speed = 0f`. This means that the rate of growth on the gameobject is stopped once it gets to a certain value.