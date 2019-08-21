# Item Counter

This will show you how to create a counter for how many items left in a scene. Before starting, the Item Collection Script needs to be
made first. Refer to the `ItemCollection.md` Gist.

## Creating an event system

In your unity scene, at the top of the screen, go to GameObject > UI > Event System.

## Creating the UI Text

 At the top of the screen, go to GameObject > UI > Text. This creates a canvas and text. 
 
 Go into 2D view by pressing the 2D button just above the scene window. With the Text selected in the hierarchy, press F2 to rename
 the text to `ObjectNum` (YOU MUST CALL IT THIS). Press F to find the text in the screen window.
 
 Move the text somewhere in the canvas, and in the text settings, Change the Font size to 50. You will have to readjust the size of
 the text box in order to see the text.

## Creating the Script

In the Event System's settings on the right side of the screen, press Add Component > New Script. Name this script `CountObjects`.

Right click on the Script and press Edit Script to open the script.

Under Line 3, type in `Using UnityEngine.UI`. This makes sure that your script refers to UI in Unity.

under `public class CountObjects : MonoBehaviour {`, Create a `GameObject` and call it "ObjUI".

under `void Start()`, inside the braces(curly brackets), type in `ObjUI = GameObject.Find("ObjectNum")` (This is why it is essential
that you name the text "ObjectNum").

Now, under  `void Update()` inside the braces, type `objUI.GetComponent<Text>().text = Collect.objects.ToString()`