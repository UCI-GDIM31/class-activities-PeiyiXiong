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


How my code works
Every bounce, _bounces increases and shows on screen.
Red (r) goes up by 0.1 and resets to 0 if it gets over 1.
Green (g) goes down by 0.1 and resets to 1 if it gets below 0.
Blue (b) multiplies by 1.2 and resets to 0.1 if it reaches 1.
Brightness is the average of r, g, b and shows on screen.
The ball changes color every bounce, and the bounce count and brightness update correctly.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
