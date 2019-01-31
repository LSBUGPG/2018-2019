# Character Movement

This will show you through creating a character and making it move.

# Creating the Character

Start on an Untitled Scene. Create a GameObject 3D Cube and give it the name ` Player `.

Create a Material and select and name it ` Blue `. click and drag it onto the ` Player `

In the Top-right corner, there is a drop-down menu named `tags`. By default, it is currently untagged. Change it to `Player`.

# Adding the Movement 

Create a new C# Script and name it ` Movement `.

Open the script. Add 3 `float` variables  under the Public class. 2 will be named ` PosX ` and ` PosY `.

```
public class Movement : MonoBehaviour {

	float posX;
	float posY;
}
```
Under `void Start`, add a reference between the floats and the transform.

```
// Use this for initialization
	void Start () {
		posX = transform.position.x;
		posY = transform.position.y;
	}
```
Now you can add the `speed` variables. There needs to be 2 speed variables. One for X and one for Y. 

Under the posX and posY floats, create 2 more floats named `xspeed` and `yspeed`. These will have a value of 0.1f.

```
public class Movement : MonoBehaviour {

	float posX;
	float posY;
	float xspeed = 0.1f;
	float yspeed = 0.1f;
}
```
Next, under `void Update`, you need to add the code to move the cube. You do this by using `transform.position = new Vector3` and in brackets, apply the `posX` and `posY` variables followed by a 0. 

```
 // Update is called once per frame
    void Update() {
        transform.position = new Vector3(posX, posY, 0);
	}
```
# Adding Keybinds

Under the previous code, type `if` and press Tab twice. This will automatically give an `if` statement.

```
if (true){

}
```

Delete the "true" and type in `Input.GetKey`, then in the same brackets, make another set of brackets, and in this set, type in `Keycode.UpArrow`.

```
if (Input.GetKey (KeyCode.UpArrow)){

}
```

Now that one Keybind code has been made, you have to declare what this button does.

under the previous code, type `posY += yspeed` this makes the position of the cube increase in value on the Y axis.

```
if (Input.GetKey (KeyCode.UpArrow)){
posY += yspeed

}
```

Repeat this process with the down arrow, changing `UpArrow` to `DownArrow` and changing the `+` to `-`
```
if (Input.GetKey (KeyCode.DownArrow)){
posY -= yspeed

}
```
The left and right arrow keys are the same process, but `posY` is replaced by `posX` and `yspeed` is replaced by `xspeed`.

The left arrow code will be similar to the down arrow code as you use `-=`, while the right arrow uses `+=`
