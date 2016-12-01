using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListListStringRotator
{

    public void rotatePattern ( List<List<string>> unrotatedPattern , string direction ) {

        Debug.Log( "running rotatePattern ( " + direction + " ) within ListRotator" );

        List<List<string>> rotatedPattern;

        //if direction is Up, we're just going to use our original pattern without rotating;
        if ( direction == "Up" ) {
            rotatedPattern = unrotatedPattern;
        }
        //but otherwise...
        else {

            int c = -1;             //(we'll use this to keep track of our new List's "rows" as we go)

            if ( direction == "Left" ) {            //rotate unrotatedPattern 90 degrees to the left

                for ( int a = unrotatedPattern.Count - 1 ; a > -1 ; a-- ) {
                    rotatedPattern.Add( new List<string>() );
                    c++;
                    for ( int b = 0 ; b < unrotatedPattern.Count ; b++ ) {
                        rotatedPattern[ c ].Add( unrotatedPattern[ b ][ a ] );
                    }
                }
            }
            else if ( direction == "Down" ) {       //rotate unrotatedPattern 180 degrees

                for ( int a = unrotatedPattern.Count - 1 ; a > -1 ; a-- ) {
                    rotatedPattern.Add( new List<string>() );
                    c++;
                    for ( int b = unrotatedPattern.Count - 1 ; b > -1 ; b-- ) {
                        rotatedPattern[ c ].Add( unrotatedPattern[ a ][ b ] );
                    }
                }
            }
            else if ( direction == "Right" ) {		//rotate unrotatedPattern 90 degrees to the right

                //create blank dummy List first for this one
                for ( int a = 0 ; a < unrotatedPattern.Count ; a++ ) {
                    rotatedPattern.Add( new List<string>() );
                    for ( int b = 0 ; b < unrotatedPattern[ a ].Count ; b++ ) {
                        rotatedPattern[ a ].Add( "!" );
                    }
                }

                for ( int a = unrotatedPattern.Count - 1 ; a > -1 ; a-- ) {
                    c++;
                    for ( int b = unrotatedPattern.Count - 1 ; b > -1 ; b-- ) {
                        rotatedPattern[ a ].RemoveAt( 0 );
                        rotatedPattern[ a ].Add( unrotatedPattern[ b ][ a ] );
                    }
                }
            }
            else {                                  //no direction supplied? same as Up; don't rotate
                reticlePattern = unrotatedPattern;
            }
        }

        return rotatedPattern;                      //and we're done!
    }

}
