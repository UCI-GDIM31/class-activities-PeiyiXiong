# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
Hello World!

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1. Why are r, g, and b floats?
   
They are floats because colors need numbers between 0.0 and 1.0. Floats can have decimals, but ints, bools, or strings cannot.

2. Why is _bounces an int?

_bounces counts how many times the ball bounced. Bounce counts are whole numbers, so int is best.

3. What did an error tell you?
   
In Step 2, I wrote r += 0.1 without f. Unity gave an error because r is a float. Adding f like 0.1f fixed it.


### W3
1. I belong to Table 5, and I will be answering question 1.

Q: You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.

The input will include float x and float y. Float x refers to the moment when player's finger touches the screen. Float y refers to the moment when player's finger leaves the screen. In the body part of the method, we will substract y from x to obtain float z. If z is greater than 0.2s, then bool whetherHit equals true. The boolean type whetherHit variable will be the output.

Input: float x (touch time); float y (leave time)

Output type: boolean

2. Class is a family recipe for how to make and present a dish that has been passed down through different generations. Components are the printed version of the recipe in a cookbook. Method is the cooking steps for this dish. Member variables are the ingredients of this dish.

3. The balls get extremely bright in the Scene if they bounce too many times because every time they hit something, their color gets brighter. In the BallW3 script, I wrote code that increases the pink, green, and blue values a little bit each time the ball collides. If the ball keeps bouncing, these values add up, and the color becomes very bright. That’s why after many bounces, the balls look almost glowing or super bright.

How my code works

Every bounce, _bounces increases and shows on screen.
Red (r) goes up by 0.1 and resets to 0 if it gets over 1.
Green (g) goes down by 0.1 and resets to 1 if it gets below 0.
Blue (b) multiplies by 1.2 and resets to 0.1 if it reaches 1.
Brightness is the average of r, g, b and shows on screen.
The ball changes color every bounce, and the bounce count and brightness update correctly.

### W4

table 5

These lines of code do the following: Line 5 creates a variable called `_moveSpeed` that tells the cat how fast it should move. The word `private` means that only this script can use it, but `[SerializeField]` makes it possible to change the speed in Unity’s Inspector, which is the place where you can edit game objects. Line 22 uses `transform.Translate(0, 0, translation)` to actually move the cat forward or backward depending on what the player presses on the keyboard, without moving it side to side or up and down. Line 25, `_rigidBody.linearVelocity = new Vector3(_rigidBody.linearVelocity.x, 0f, _rigidBody.linearVelocity.z);`, sets the cat’s vertical speed to 0 before it jumps, so that the jump always starts cleanly and is not affected by any previous movement up or down. This makes the cat jump in a smooth and predictable way.



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
