namespace Unit03 {
    
    using Console = game.console.Console;
    
    using Jumper = game.jumper.Jumper;
    
    using Word = game.word.Word;
    
    public static class Module {
        
        // A code template for a person who directs the game. The responsibility of 
        //     this class of objects is to control the sequence of play.
        //     
        //     Stereotype:
        //         Controller
        //     Attributes:
        //         console (Console): An instance of the class of objects known as Console.
        //         keep_playing (boolean): Whether or not the game can continue.
        //         
        //     
        public class Director {
            
            public Director() {
                this.console = Console();
                this.word = Word();
                this.jumper = Jumper(this.word.correctWord);
                this.keep_playing = true;
            }
            
            // Starts the game loop to control the sequence of play.
            //         
            //         Args:
            //             self (Director): an instance of Director.
            //         
            public virtual object start_game() {
                while (this.keep_playing) {
                    this.get_inputs();
                    this.do_updates();
                    this.do_outputs();
                }
            }
            
            // Gets the inputs from user at the beginning of each round
            //         of play. Send update array to jumper
            //         Args:
            //             self (Director): An instance of Director.
            //         
            public virtual object get_inputs() {
                var message = "";
                foreach (var element in this.jumper.displayArray) {
                    // Line added
                    message = message + element + " ";
                }
                this.console.write(message);
                message = this.jumper.picture();
                this.console.write(message);
                var oneLetterResponse = false;
                while (!oneLetterResponse) {
                    this.guess = this.console.read("Guess a letter [a-z]: ");
                    if (this.guess.Count != 1) {
                        Console.WriteLine("\nPlease enter one letter. No more, no less.\n");
                    } else {
                        oneLetterResponse = true;
                    }
                }
            }
            
            // Updates the important game information for each round of play.
            //         check the word (boolean value).
            //         Args:
            //             self (Director): An instance of Director.
            //         
            public virtual object do_updates() {
                this.positionsOfCorrect = this.word.checkLetter(this.guess);
                this.jumper.updateArray(this.positionsOfCorrect, this.guess);
                this.checkVictory = this.jumper.checkVictory();
                this.checkDefeat = this.jumper.checkDefeat();
            }
            
            // Outputs the important game information for each round of play. In 
            //             checkVictory
            //             checkDefeat
            //         Args:
            //             self (Director): An instance of Director.
            //         
            public virtual object do_outputs() {
                object message;
                if (this.checkVictory == true) {
                    //Checks to see if you've won. Still needs lots of testing
                    message = "Congratulations, you won! The word was: ";
                    this.console.write(message);
                    message = "\n" + this.word.correctWord;
                    this.console.write(message);
                    this.keep_playing = false;
                } else if (this.checkDefeat == true) {
                    //checks to see if you've lost, still needs lots of testing. 
                    message = this.jumper.picture();
                    this.console.write(message);
                    message = "\nSorry! Try again! Your word was: ";
                    this.console.write(message);
                    message = "\n" + this.word.correctWord;
                    this.console.write(message);
                    this.keep_playing = false;
                }
            }
        }
    }
}
