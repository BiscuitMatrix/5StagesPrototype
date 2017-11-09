using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*   <<<< Main loop >>>> - Spawn, initial settings, animation, gamestate to -beginning-
 *                          > Beginning - any initial setup, splash screen of instructions, small animation, etc etc
 *                                  - Generate first trap layers & spawn offscreen
 *                                  - Character move horizontally to trap position, gamestate to -moving-
 *                          > Moving - constant velocity right, "walk" cycle, background parallax and move around 1.5 view lengths to new trap's position
 *                                      - play trapping animation/sound, gamestate to -trapped- 
 *                          > Trapped - begin timer
 *                                    - accept, count & show count for discrete touch inputs
 *                                    - if count = layers, begin new (1 second?) timer, if more touches are detected, run fail (too many) sequence
 *                                                          else run success sequence
 *                                    - else if timer runs out, and layer count not matched, run fail (too few) sequence
 *                          > success sequence - break-trap animation, PC jumps up and right, when it lands constant velocity right + "walk cycle" + background parallax & move 1.5L to new trap                                  
                                    - run procedural progression (On successful trap break below)
                                    - reduce next trap start timer
                                    - Moving state
                            > Repeat per block (see below - play progression)
                            > Gravity is currently set at -15m/s/s up from default 9.81 to bandaid fix floaty jumps
    
     <<<< Traps >>>>
        > Store procedural traps in list/vector
        > On successful trap break, begin on-screen events
            generate new next, spawn assets
            Assets for trap - ice layers, believable convergence/divergence (or sleight of hand eg. blizzard), snow floor, 
                                trap object (flat spot, ice shards pointing up when trapped), trap collider, trap script
     
     <<<< Dos >>>>
        > platform destructor - same idea as constructor
        > have no instances of platforms at the start - DONE -> Prefabs bruh
        > procedurally extend "surface" and "floor" planes
        > actually put stuff in Main_DE script! Other than comments!
                    >> (wanting triggers and inputs filtering through Main_DE for UI and any overarching mechanics)
                    >> (rather than passing direct to other objects' scripts)

    <<<< Hows? >>>>
        > properly developed gamestates
        > Water effect
        > full procedural generation
        > parallax backgrounds

    <<<< Extra suggestions >>>>
        > Play progression - pauses between gameplay blocks - 
                             ie iceberg break going to next landmass, count up current points, 
                             show previous best etc idk - character taking a breather
        > something-in-the-water swirl/shadow effect during trap/constantly following under player 
                    >> to suggest the idea of Black Dog analogy for depression
        > Blizzard weather effect
        > other varying environment methods for indicating progression?
                    >> day/night, changes in weather, wind, background tiles
                    >> slopes, vertical element, other types of traps? (ice walls blocking path?)
        > timed taps gameplay like rhythmn or Space Frontier, rather than 1-5x taps quickly? 
                    >> Possibly timed visually with dark thing in water rising up through the layers at ya
                    >> Rewards careful timing rather than button mashing, which might be more frustrating to fail
                    >> Morse Code timing!


    <<<< Design Questions >>>>
        
        > Need a more fleshed out design for environment
                    >> happy with this viewpoint or rather go full 2D and have a flat slice?
                    >> Decided on frozen lake as setting, and layers of ice below the character as the traps?
        > Thinking more about early/mid/late game - Graeme's difficulty block pacing idea (outlined a little above)
        > mixing up gameplay/progression between sessions etc
     */
public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Player_Controller_DE player_Controller;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
