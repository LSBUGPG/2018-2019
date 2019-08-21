# Item Collection

This will show you how to create code to collect items and how to create the items themselves. Before starting, the player needs to be made. Refer to the
`CharacterMovement.md` Gist.

# Creating the item

Create a GameObject 3D Cube. Go to the hierarchy, press F2 and rename it ` Coin `. on the right side of the screen, press 
Add Component > Physics > Rigidbody. In the Rigidbody settings, Untick the "Use Gravity" box.

# Adding the Code

With the coin still selected, on the right side of the screen, press Add Component > New Script. Name this script `Collect`.

Right click on the Script and press Edit Script to open the script.

Under line 5 `public class Collect : MonoBehaviour {`, create a `public static int` variable and name it `objects`. Give it a value of 0.

Change `void Start ()` to `void Awake ()`, and in between the braces (curly brackets) direcly below, type in `objects++` this means that the value of the 
variable named `objects` increases with the amount of items with this script in the scene.

Replace `Void Update ()` with `private void OnTriggerEnter(Collider plyr)`. In between the braces, type `if` then press tab twice, this should 
autocomplete the statement. 

in the Brackets, delete where it says "true" and type in `plyr.gameObject.tag== "Player"`

in between the braces below, type `gameObject.SetActive(false)` this makes the coin disappear. 

Under that, still within the braces, type `objects--` this means the value will decrease when the coin disappears from the scene.