using System;

namespace Unit03
{
     using Director = game.Director.Director;
    
    public static class Module {
        
        public static object director = Director();
        
        static Module() {
            director.start_game();
        }
    }
}
