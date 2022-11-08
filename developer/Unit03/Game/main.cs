namespace Unit03{
    
    using Director = game.director.Director;
    
    public static class Module {
        
        public static object director = Director();
        
        static Module() {
            director.start_game();
        }
    }
}