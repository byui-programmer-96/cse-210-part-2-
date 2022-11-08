namespace Namespace {
    
    using random;
    
    public static class Module {
        
        // A code template for a computer console. The responsibility of this 
        //     class of objects is to get text or numerical input and display text output.
        //     
        //     Stereotype:
        //         Service Provider, Interfacer
        // 
        //     Attributes:
        //         prompt (string): The prompt to display on each line.
        //     
        public class Console {
            
            // Gets text input from the user through the screen.
            // 
            //         Args: 
            //             self (Screen): An instance of Screen.
            //             prompt (string): The prompt to display to the user.
            // 
            //         Returns:
            //             string: The user's input as text.
            //         
            public virtual object read(object prompt) {
                return input(prompt);
            }
            
            // Gets numerical input from the user through the screen.
            // 
            //         Args: 
            //             self (Screen): An instance of Screen.
            //             prompt (string): The prompt to display to the user.
            // 
            //         Returns:
            //             float: The user's input as a float.
            //         
            public virtual object read_letter(object prompt) {
                return float(input(prompt));
            }
            
            // Displays the given text on the screen. 
            // 
            //         Args: 
            //             self (Screen): An instance of Screen.
            //             text (string): The text to display.
            //         
            public virtual object write(object text) {
                Console.WriteLine(text);
            }
        }
    }
}
