When this mod was initially released, bone was given the color (191,151,235) or DBC2AB. I do not know how I came to settle on that color, as it has virtually no commonality with any reference material I could find. I thought I could do better, and decided to document my thought process for future me and the pathologically curious. If you're reading this: hi!

In RimWorld, skeletons and some other items such as skulls that are nominally made of bone use the color (192, 192, 192) or C0C0C0, which is an unacceptably boring grey color.

The ColorDef for "Structure_White" is (184, 184, 184) or B8B8B8, further establishing the notion that baseline "white" in RimWorld is more of a light grey color. Anything with an HSV value of greater than 75 is therefore "brighter than white" which helps explain the unnatural brightness of bone and thrumbone when seen ingame.

Keeping this in mind, I went searching for a better bone color.

When searching with DuckDuckGo for "bone rgb" four of the top five results agreed that E3DAC9 is the color of bone. I decided to accept this answer.

Normalizing the HSV value of E3DAC9 against RimWorld's "white" gives me an RGB of AAA498. This color is distressingly similar to silver's ingame color of B4AD96, which I did not find acceptable. Matching the HSV value of "white" rather than normalizing against it gave me BFB7AA or (191, 183, 170), a much more distinct color that I liked.

From there I needed to come up with a color for thrumbone. This was fairly simple; I took the triadic complementary color of regular bone and tripled the saturation, giving a nice muted purple color of B197BF or (169, 128, 191).