namespace Unit03 {
    
    using random;
    
    using System.Collections.Generic;
    
    public static class Module {
        
        // A game of hangman with a twist. The responsibility of this class is to keep track of the
        //     users guesses and times failed as they try to guess the word that is ramdomly chosen from
        //     a large list.
        //     Stereotype:
        //         Information Holder
        //     Attributes:
        //         answer (list): The users letter guesses
        //         fails (integer): The number of failed guesses
        //         displayArray (list): The letters ("_") in the random word not guessed by user.
        //     
        public class Jumper {
            
            public Jumper(object correctWord) {
                this.answer = new List<object>();
                this.fails = 0;
                this.displayArray = new List<object>();
                var i = 0;
                while (i != correctWord.Count) {
                    this.displayArray.append("_");
                    i = i + 1;
                }
            }
            
            // Gets a message from the jumper.
            //         Args:
            //             self (Jumper): An instance of Jumper.
            //         Returns:
            //             string: A message from the jumper.
            //         
            public virtual object picture() {
                if (this.fails == 4) {
                    var message = "\n   x\n  /|\\\n  / \\\n\n^^^^^^^";
                } else if (this.fails == 3) {
                    message = "\n  \\ / \n   0\n  /|\\\n  / \\\n\n^^^^^^^";
                } else if (this.fails == 2) {
                    message = "\n \\   / \n  \\ / \n   0\n  /|\\\n  / \\\n\n^^^^^^^";
                } else if (this.fails == 1) {
                    message = "\n /___\\\n \\   / \n  \\ / \n   0\n  /|\\\n  / \\\n\n^^^^^^^";
                } else {
                    //fails == 0: player is at full health
                    message = "  ___\n /___\\\n \\   / \n  \\ / \n   0\n  /|\\\n  / \\\n\n^^^^^^^";
                }
                return message;
            }
            
            // Checks to see if the user entered a valid letter that is found in the word.
            //         Args:
            //             self (Jumper): An instance of Jumper.
            //         
            public virtual object updateArray(object positionsOfCorrect, object guess) {
                if (!positionsOfCorrect) {
                    this.fails = this.fails + 1;
                } else {
                    foreach (var element in positionsOfCorrect) {
                        this.displayArray[element] = guess;
                    }
                }
                return;
            }
            
            // Checks to see if the user guessed a correct word yet.
            //         Args:
            //             self (Jumper): An instance of Jumper.
            //         
            public virtual object checkVictory() {
                var checkVictory = false;
                var checkSum = 0;
                foreach (var element in this.displayArray) {
                    //checkSum only iterates if an underscore is found. 
                    if (element == "_") {
                        checkSum = checkSum + 1;
                    }
                }
                if (checkSum == 0) {
                    //Only if checkSum hasn't changed will the victory be triggered. 
                    checkVictory = true;
                }
                return checkVictory;
            }
            
            // Checks to see if the user has failed four guess attempts.
            //         Args:
            //             self (Jumper): An instance of Jumper.
            //         
            public virtual object checkDefeat() {
                var checkDefeat = false;
                if (this.fails == 4) {
                    //You lose if there are 4 fails. 
                    checkDefeat = true;
                }
                return checkDefeat;
            }
        }
    }
}
